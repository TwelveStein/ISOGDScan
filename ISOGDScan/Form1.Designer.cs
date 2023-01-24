namespace ISOGDScan
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ObrabotatButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ObrabotkaButton = new System.Windows.Forms.Button();
            this.NewFolderButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newfolderLabel = new System.Windows.Forms.Label();
            this.LabelObrabotka = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StatLabel = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MainPathLabel = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NewpathLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(570, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 404);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ObrabotatButton);
            this.panel6.Controls.Add(this.ApplyButton);
            this.panel6.Controls.Add(this.ObrabotkaButton);
            this.panel6.Controls.Add(this.NewFolderButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 53);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(30);
            this.panel6.Size = new System.Drawing.Size(252, 351);
            this.panel6.TabIndex = 10;
            // 
            // ObrabotatButton
            // 
            this.ObrabotatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ObrabotatButton.Location = new System.Drawing.Point(30, 136);
            this.ObrabotatButton.Name = "ObrabotatButton";
            this.ObrabotatButton.Size = new System.Drawing.Size(192, 34);
            this.ObrabotatButton.TabIndex = 10;
            this.ObrabotatButton.Text = "Обработать";
            this.ObrabotatButton.UseVisualStyleBackColor = true;
            this.ObrabotatButton.Click += new System.EventHandler(this.ObrabotatButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplyButton.Location = new System.Drawing.Point(30, 102);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(192, 34);
            this.ApplyButton.TabIndex = 11;
            this.ApplyButton.Text = "Подтвердить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ObrabotkaButton
            // 
            this.ObrabotkaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ObrabotkaButton.Location = new System.Drawing.Point(30, 66);
            this.ObrabotkaButton.Name = "ObrabotkaButton";
            this.ObrabotkaButton.Size = new System.Drawing.Size(192, 36);
            this.ObrabotkaButton.TabIndex = 9;
            this.ObrabotkaButton.Text = "Выберите папку для обработки";
            this.ObrabotkaButton.UseVisualStyleBackColor = true;
            this.ObrabotkaButton.Click += new System.EventHandler(this.ObrabotkaButton_Click);
            // 
            // NewFolderButton
            // 
            this.NewFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewFolderButton.Location = new System.Drawing.Point(30, 30);
            this.NewFolderButton.Name = "NewFolderButton";
            this.NewFolderButton.Size = new System.Drawing.Size(192, 36);
            this.NewFolderButton.TabIndex = 8;
            this.NewFolderButton.Text = "Выберите конечную папку";
            this.NewFolderButton.UseVisualStyleBackColor = true;
            this.NewFolderButton.Click += new System.EventHandler(this.NewFolderButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 47);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Панель управления";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.newfolderLabel);
            this.panel2.Controls.Add(this.LabelObrabotka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 47);
            this.panel2.TabIndex = 5;
            // 
            // newfolderLabel
            // 
            this.newfolderLabel.AutoSize = true;
            this.newfolderLabel.Location = new System.Drawing.Point(12, 28);
            this.newfolderLabel.Name = "newfolderLabel";
            this.newfolderLabel.Size = new System.Drawing.Size(94, 13);
            this.newfolderLabel.TabIndex = 2;
            this.newfolderLabel.Text = "Конечная папка: ";
            // 
            // LabelObrabotka
            // 
            this.LabelObrabotka.AutoSize = true;
            this.LabelObrabotka.Location = new System.Drawing.Point(12, 9);
            this.LabelObrabotka.Name = "LabelObrabotka";
            this.LabelObrabotka.Size = new System.Drawing.Size(122, 13);
            this.LabelObrabotka.TabIndex = 1;
            this.LabelObrabotka.Text = "Папка для обработки: ";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 309);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pdf.png");
            this.imageList1.Images.SetKeyName(1, "Folder.png");
            this.imageList1.Images.SetKeyName(2, "done.png");
            this.imageList1.Images.SetKeyName(3, "propusk.png");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(570, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // StatLabel
            // 
            this.StatLabel.AutoSize = true;
            this.StatLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatLabel.Location = new System.Drawing.Point(6, 386);
            this.StatLabel.Name = "StatLabel";
            this.StatLabel.Size = new System.Drawing.Size(0, 13);
            this.StatLabel.TabIndex = 10;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(263, 72);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(307, 309);
            this.listView2.SmallImageList = this.imageList1;
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.MainPathLabel);
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 25);
            this.panel4.TabIndex = 14;
            // 
            // MainPathLabel
            // 
            this.MainPathLabel.AutoSize = true;
            this.MainPathLabel.LinkColor = System.Drawing.Color.Black;
            this.MainPathLabel.Location = new System.Drawing.Point(12, 6);
            this.MainPathLabel.Name = "MainPathLabel";
            this.MainPathLabel.Size = new System.Drawing.Size(97, 13);
            this.MainPathLabel.TabIndex = 17;
            this.MainPathLabel.TabStop = true;
            this.MainPathLabel.Text = "Папка с файлами";
            this.MainPathLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainPathLabel_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.NewpathLabel);
            this.panel5.Location = new System.Drawing.Point(263, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 25);
            this.panel5.TabIndex = 15;
            // 
            // NewpathLabel
            // 
            this.NewpathLabel.AutoSize = true;
            this.NewpathLabel.LinkColor = System.Drawing.Color.Black;
            this.NewpathLabel.Location = new System.Drawing.Point(16, 6);
            this.NewpathLabel.Name = "NewpathLabel";
            this.NewpathLabel.Size = new System.Drawing.Size(88, 13);
            this.NewpathLabel.TabIndex = 0;
            this.NewpathLabel.TabStop = true;
            this.NewpathLabel.Text = "Конечная папка";
            this.NewpathLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewpathLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 404);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.StatLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внесу ИСОГД (Auto)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label newfolderLabel;
        private System.Windows.Forms.Label LabelObrabotka;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label StatLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel MainPathLabel;
        private System.Windows.Forms.LinkLabel NewpathLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ObrabotatButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button ObrabotkaButton;
        private System.Windows.Forms.Button NewFolderButton;
    }
}

