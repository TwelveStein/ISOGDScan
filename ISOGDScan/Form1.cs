using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using static System.Threading.Thread;
using System.Diagnostics;

namespace ISOGDScan
{
    public partial class MainForm : Form
    {
        private PDFSearch pdfSearch;
        public string mainpath = null;
        public string newpath = null;
        public string[] FilesOnDirectory;
        public string[] Sorted;
        public string[] PDFMassive;
        public string kvartal_number;
        public string house_number;
        public string choosedFile;
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pdfSearch = PDFSearch.getInstance();
            ObrabotatButton.Enabled = false;
            MainPathLabel.Enabled = false;
            NewpathLabel.Enabled = false;
            progressBar1.Minimum = 0;
        }


        private void CurrentPaths()
        {
            LabelObrabotka.Text = "Папка для обработки: " + mainpath;
            newfolderLabel.Text = "Конечная папка: " + newpath;

        }
        private void ObrabotkaButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                mainpath = folderBrowserDialog1.SelectedPath;
                CurrentPaths();
                MainPathLabel.Enabled = true;
                MainPathLabel.Text = "Папка с файлами: " + mainpath.Substring(mainpath.LastIndexOf('\\') + 1);
                
            }
            //FilesOnDirectory = Directory.GetFiles(mainpath);
        }
        private void NewFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                newpath = folderBrowserDialog2.SelectedPath;
                CurrentPaths();
                NewpathLabel.Enabled = true;
                NewpathLabel.Text = "Конечная папка: " + newpath.Substring(newpath.LastIndexOf('\\') + 1);
            }
        }

        public void ListBoxShow()
        {
            int NumberCount = 1;
            
                foreach (string file in PDFMassive)
                {
                    ListViewItem lvi = new ListViewItem();
                    // установка названия файла
                    lvi.Text = "№ " + NumberCount + " | " + Path.GetFileNameWithoutExtension(file);
                    NumberCount++;
                    switch (Path.GetExtension(file))
                    {
                        case (".pdf"):
                            lvi.ImageIndex = 0;
                            break;
                        case (".xlsx"):
                            lvi.ImageIndex = 1;
                            break;
                        case (".docx"):
                            lvi.ImageIndex = 2;
                            break;
                        case (".pptx"):
                            lvi.ImageIndex = 3;
                            break;
                        default:
                            lvi.ImageIndex = 4;
                            break;
                    }
                    listView1.Items.Add(lvi);
                }
            ColoredFile();
        }
        public void ListTest(string kvartal, string number, string name)
        {
            ListViewItem lvi2 = new ListViewItem();
            lvi2.Text = kvartal + " | " + number + " | " + Path.GetFileNameWithoutExtension(name);
            lvi2.ImageIndex = 1;
            if (number != null && kvartal!=null) listView2.Items.Add(lvi2);
        }
        BackgroundWorker backgroundWorkerPdfHahdle;
        private void ObrabotatButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Images");
            DisableButtons(false);
            StatLabel.Text = null;
            RefreshData();
            backgroundWorkerPdfHahdle = new BackgroundWorker();
            backgroundWorkerPdfHahdle.DoWork += (obj, ea) => PdfHandleAsync();
            backgroundWorkerPdfHahdle.RunWorkerAsync(); 
            progressBar1.Value = 0;
            StatLabel.Text = "Файлов всего: " + CountPDF(FilesOnDirectory) + " |" + " Обработано: " + Countplus(FilesOnDirectory) + $" ({100 * Countplus(FilesOnDirectory) / CountPDF(FilesOnDirectory)}%) " + "|" + " Пропущено: " + CountPropusk(FilesOnDirectory) + $" ({100 * CountPropusk(FilesOnDirectory) / CountPDF(FilesOnDirectory)}%)";
            DisableButtons(true);
            Directory.Delete("Images", true);
        }

        public void GetFilesFromMassive()
        {
            FilesOnDirectory = Directory.GetFiles(mainpath);
        }

        public int CountPDF(string[] Array)
        {
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].Contains(".pdf")) count++;
            }
            return count;
        }
        public int CountPropusk(string[] Array)
        {
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (!Array[i].Contains("+") && Array[i].Contains("Пропущен") && Array[i].Contains(".pdf")) count++;
            }
            return count;
        }
        public int Countplus(string[] Array)
        {
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].Contains("+")) count++;
            }
            return count;
        }
        public void SortPDFMassive()
        {
            int jey = 0;
            int count = 0;
            for (int i = 0; i < FilesOnDirectory.Length; i++)
            {
                if (!FilesOnDirectory[i].Contains("+") && Path.GetExtension(FilesOnDirectory[i]) == (".pdf") && !FilesOnDirectory[i].Contains(" (Пропущен)"))
                {
                    count++;
                }
            }
            Sorted = new string[count];
            for (int i = 0; i < FilesOnDirectory.Length; i++)
            {
                if (!FilesOnDirectory[i].Contains("+") && Path.GetExtension(FilesOnDirectory[i]) == (".pdf") && !FilesOnDirectory[i].Contains(" (Пропущен)"))
                {
                    Sorted[jey] = FilesOnDirectory[i];
                    jey++;
                }
            }
            jey = 0;
            PDFMassive = new string[CountPDF(FilesOnDirectory)];
            for (int i = 0; i < FilesOnDirectory.Length; i++)
            {
                if (Path.GetExtension(FilesOnDirectory[i]) == (".pdf"))
                {
                    PDFMassive[jey] = FilesOnDirectory[i];
                    jey++;
                }
            }
        }

        private void ColoredFile()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                if (lvi.Text.Contains("+"))
                {
                    lvi.BackColor = Color.LightGreen;
                    lvi.ImageIndex = 2;
                }
                else if (lvi.Text.Contains("Пропущен"))
                {
                    lvi.BackColor = Color.LightGray;
                    lvi.ImageIndex = 3;
                }
            }
        }
        async void PdfHandleAsync() 
        {
            PDFHandle();
        }

        private void PDFHandle()
        {
            //PDFMassive - это массив с файлами ПДФ. тут могут быть и обработаные и пропущенные
            //Sorted - Массив с файлами ПДФ, тут нет обработаных и пропущеных.
            foreach (string file in Sorted)
            {
                    kvartal_number = pdfSearch.Text_Seacher(pdfSearch.TextToPdfExsporter(file))[2];
                    house_number = pdfSearch.Text_Seacher(pdfSearch.TextToPdfExsporter(file))[3];
                    ListTest(kvartal_number, house_number, file);
                if (PDFSearch.Status_Pdf)
                {
                    //если квартала нет
                    if (!Directory.Exists(newpath + @"\" + kvartal_number))
                    {
                        Directory.CreateDirectory(newpath + @"\" + kvartal_number);
                    }
                    //если нет папки
                    if (!Directory.Exists(newpath + @"\" + kvartal_number + @"\" + house_number))
                    {
                        Directory.CreateDirectory(newpath + @"\" + kvartal_number + @"\" + house_number);
                    }
                    MainAlgorithm(file);
                }
                else
                {
                    if (!file.Contains(" (Пропущен)"))
                    {
                        File.Move(file, file.Remove(file.Length - 4) + " (Пропущен)" + ".pdf");
                    }
                    
                }
                progressBar1.PerformStep();
                RefreshData();

            }
        }
        private void MainAlgorithm(string file)
        {
            string finaldir = newpath;
            finaldir += "\\" + kvartal_number.Trim();
            finaldir += "\\" + house_number.Trim();
            finaldir += "\\" + Path.GetFileName(file);

            try
            {
                File.Copy(file, finaldir, true);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(finaldir);//имя файла введено некорректно
            }
            if (File.Exists(file.Remove(file.Length - 4) + "+" + ".pdf"))
            {
                File.Delete(file.Remove(file.Length - 4) + "+" + ".pdf");
            }
            File.Move(file, file.Remove(file.Length - 4) + "+" + ".pdf");
        }


        private void RefreshData()
        {
            GetFilesFromMassive();
            SortPDFMassive();
            CurrentPaths();
            listView1.Clear();
            ListBoxShow();
            ColoredFile();
            progressBar1.Maximum = CountPDF(FilesOnDirectory);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            
            if ((mainpath == null || newpath == null) ||
                (mainpath == null && newpath == null) || 
                (mainpath == newpath))
            {
                DialogResult dialogResult = MessageBox.Show($"Неккоректно заданы пути", "Ошибка", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    CurrentPaths();
                }
            }
            else if ((mainpath != null || newpath != null) || (mainpath != null && newpath == null) || !(mainpath == newpath))
            {
                //GetFilesFromMassive();
                //SortPDFMassive();
                RefreshData();
                StatLabel.Text = "Файлов всего: " + CountPDF(FilesOnDirectory) + " |" + " Обработано: " + Countplus(FilesOnDirectory) + $" ({100 * Countplus(FilesOnDirectory) / CountPDF(FilesOnDirectory)}%) " + "|" + " Пропущено: " + CountPropusk(FilesOnDirectory) + $" ({100 * CountPropusk(FilesOnDirectory) / CountPDF(FilesOnDirectory)}%)";
                ObrabotatButton.Enabled = true;
            }
            else if (CountPDF(FilesOnDirectory) == 0)
            {
                DialogResult dialogResult = MessageBox.Show($"В директории {mainpath} нет документов формата .pdf\nВыберите другую директорию или повторите попытку", "Ошибка", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    CurrentPaths();
                }
            }
            else if (Countplus(Sorted) == Sorted.Length || (CountPropusk(FilesOnDirectory) + Countplus(Sorted) == Sorted.Length))
            {
                DialogResult dialogResult = MessageBox.Show($"Все файлы в директории {mainpath} уже обработаны.\nВыберите другую директорию или повторите попытку", "Ошибка", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    CurrentPaths();
                }
            }


        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                choosedFile = (string)listView2.SelectedItems[0].Text;
                choosedFile = newpath + @"\" + choosedFile.Replace(" | ", @"\") + ".pdf";
                choosedFile = choosedFile.Remove(choosedFile.LastIndexOf("\\"));
                choosedFile.Trim();
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            //Stream logtxt = new FileStream(choosedFile, FileMode.Open);
            Process.Start("explorer.exe", choosedFile);

        }

        private void DisableButtons(bool status)
        {
            if (status == true)
            {
                ObrabotkaButton.Enabled = true;
                NewFolderButton.Enabled = true;
                ApplyButton.Enabled = true;
                ObrabotatButton.Enabled = true;
                MainPathLabel.Enabled = true;
                NewpathLabel.Enabled = true;
            }
            else if (status == false)
            {
                ObrabotkaButton.Enabled = false;
                NewFolderButton.Enabled = false;
                ApplyButton.Enabled = false;
                ObrabotatButton.Enabled = false;
                MainPathLabel.Enabled = false;
                NewpathLabel.Enabled = false;
            }
        }

        private void MainPathLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", mainpath);
        }

        private void NewpathLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", newpath);
        }
    }
}
