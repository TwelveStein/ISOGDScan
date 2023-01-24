using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using Tesseract;
using Pdf2Image;
using System.IO;

namespace ISOGDScan
{
    public class PDFSearch
    {
        public static bool Status_Pdf = false;
        //public static string[] Numbers;
        public static string[] Text_Seacher(string text)
        {
            //public static bool Status_Pdf = false;
            string[] Numbers = new string[4];
            #region WorkCode
            
            string Key_text = "", Key_text2 = "",tmp = "";// = "Кадастровый номер земельного участка";

            string[] Keys_texts = new string[] { "Кадастровыйномерземельногоучастка(приналичии)", "Кадастровыйномерземельногоучастка", "кадастровыйномер" };
            foreach (string i in Keys_texts)
            {
                if (text.Contains(i))
                {
                    Key_text = i;
                    if (i == Keys_texts[0] || i == Keys_texts[1])
                    {
                        Key_text2 = "Площадь";
                    }
                    else if (i == Keys_texts[2])
                    { Key_text2 = ","; }
                    break;
                }
            }
            if (!String.IsNullOrEmpty(Key_text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i > text.IndexOf(Key_text) + Key_text.Length - 1)
                    {
                        tmp += text[i];
                        if (tmp.Contains(Key_text2))
                        {
                            tmp = tmp.Remove(tmp.Length - Key_text2.Length, Key_text2.Length);
                            break;
                        }
                    }
                }
                text = tmp;
                Status_Pdf = true;
                Numbers = text.Split(':');
            }
            else
            {
                Status_Pdf = false;
            }
            
            #endregion

            return Numbers;
        }
        /// <summary>
        /// Переводит PDF в текст 
        /// </summary>
        /// <param name="n">Путь к файлу</param>
        public static string TextToPdfExsporter(string n)
        {
            string result = "";
            PdfReader reader = new PdfReader(n);
            PdfDocument PdfDoc = new PdfDocument(reader);
            for (int page = 1; page < PdfDoc.GetNumberOfPages(); page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                result += PdfTextExtractor.GetTextFromPage(PdfDoc.GetPage(page), strategy);
            }
            if (result == "")
                result = TextToPdfExsporter_OCR_Version(n);
            PdfDoc.Close();
            reader.Close();
            return result.Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("—", "");
        }
        static string TextToPdfExsporter_OCR_Version(string n)
        {
            string result = "";
            string file = n;

            List<System.Drawing.Image> images = PdfSplitter.GetImages(file, PdfSplitter.Scale.High);
            PdfReader reader = new PdfReader(n);
            PdfDocument PdfDoc = new PdfDocument(reader);
            PdfSplitter.WriteImages(file, "Images", PdfSplitter.Scale.High, PdfSplitter.CompressionLevel.Medium);
            using (var engine = new TesseractEngine(@"tessdata", "rus", EngineMode.Default))
            {
                for (int i = 1; i < PdfDoc.GetNumberOfPages() + 1; ++i)
                {
                    string pageImage = $"Images\\{Path.GetFileNameWithoutExtension(n)}_{i}.jpg".Trim();

                    using (Pix img = Pix.LoadFromFile(pageImage))
                    {
                        using (Page recognizedPage = engine.Process(img))
                        {
                            Console.WriteLine($"Mean confidence for page #{i}: {recognizedPage.GetMeanConfidence()}");

                            result += recognizedPage.GetText();
                        }
                    }

                }
            }
            PdfDoc.Close();
            reader.Close();
            return result;
        }
    }
}

