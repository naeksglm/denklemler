namespace Denklemler
{
    partial class Denklemler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Denklemler));
            comboBox1 = new ComboBox();
            denklemTipi = new Label();
            panel1 = new Panel();
            btnDenklemCoz = new Button();
            panelD = new Panel();
            eqD = new Label();
            imgD = new PictureBox();
            panelC = new Panel();
            eqC = new Label();
            imgC = new PictureBox();
            panelB = new Panel();
            eqB = new Label();
            imgB = new PictureBox();
            panelA = new Panel();
            textA = new TextBox();
            eqA = new Label();
            imgDenklem = new PictureBox();
            imgA = new PictureBox();
            textD = new TextBox();
            textC = new TextBox();
            textB = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panelD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgD).BeginInit();
            panelC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgC).BeginInit();
            panelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgB).BeginInit();
            panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgDenklem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgA).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lütfen Denklem Tipini Seçiniz", "Birinci Dereceden Bir Bilinmeyenli Denklem", "İkinci Dereceden Bir Bilinmeyenli Denklem", "Üçüncü Dereceden Bir Bilinmeyenli Denklem" });
            comboBox1.Location = new Point(224, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(459, 38);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // denklemTipi
            // 
            denklemTipi.AutoSize = true;
            denklemTipi.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            denklemTipi.Location = new Point(12, 39);
            denklemTipi.Name = "denklemTipi";
            denklemTipi.Size = new Size(206, 40);
            denklemTipi.TabIndex = 1;
            denklemTipi.Text = "Denklem Tipi:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDenklemCoz);
            panel1.Controls.Add(panelD);
            panel1.Controls.Add(eqD);
            panel1.Controls.Add(imgD);
            panel1.Controls.Add(panelC);
            panel1.Controls.Add(eqC);
            panel1.Controls.Add(imgC);
            panel1.Controls.Add(panelB);
            panel1.Controls.Add(eqB);
            panel1.Controls.Add(imgB);
            panel1.Controls.Add(panelA);
            panel1.Controls.Add(eqA);
            panel1.Controls.Add(imgDenklem);
            panel1.Controls.Add(imgA);
            panel1.Location = new Point(12, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 671);
            panel1.TabIndex = 2;
            // 
            // btnDenklemCoz
            // 
            btnDenklemCoz.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDenklemCoz.Location = new Point(241, 525);
            btnDenklemCoz.Name = "btnDenklemCoz";
            btnDenklemCoz.Size = new Size(209, 123);
            btnDenklemCoz.TabIndex = 5;
            btnDenklemCoz.Text = "Denklemi Çöz";
            btnDenklemCoz.UseVisualStyleBackColor = true;
            // 
            // panelD
            // 
            panelD.Controls.Add(textD);
            panelD.Location = new Point(241, 425);
            panelD.Name = "panelD";
            panelD.Padding = new Padding(8, 4, 8, 4);
            panelD.Size = new Size(306, 70);
            panelD.TabIndex = 6;
            // 
            // eqD
            // 
            eqD.AutoSize = true;
            eqD.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eqD.Location = new Point(178, 407);
            eqD.Name = "eqD";
            eqD.Size = new Size(81, 86);
            eqD.TabIndex = 11;
            eqD.Text = "=";
            // 
            // imgD
            // 
            imgD.Image = (Image)resources.GetObject("imgD.Image");
            imgD.Location = new Point(137, 417);
            imgD.Name = "imgD";
            imgD.Size = new Size(48, 65);
            imgD.TabIndex = 10;
            imgD.TabStop = false;
            // 
            // panelC
            // 
            panelC.Controls.Add(textC);
            panelC.Location = new Point(241, 328);
            panelC.Name = "panelC";
            panelC.Padding = new Padding(8, 4, 8, 4);
            panelC.Size = new Size(306, 70);
            panelC.TabIndex = 12;
            // 
            // eqC
            // 
            eqC.AutoSize = true;
            eqC.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eqC.Location = new Point(178, 310);
            eqC.Name = "eqC";
            eqC.Size = new Size(81, 86);
            eqC.TabIndex = 8;
            eqC.Text = "=";
            // 
            // imgC
            // 
            imgC.Image = (Image)resources.GetObject("imgC.Image");
            imgC.Location = new Point(137, 320);
            imgC.Name = "imgC";
            imgC.Size = new Size(48, 65);
            imgC.TabIndex = 7;
            imgC.TabStop = false;
            // 
            // panelB
            // 
            panelB.Controls.Add(textB);
            panelB.Location = new Point(241, 242);
            panelB.Name = "panelB";
            panelB.Padding = new Padding(8, 4, 8, 4);
            panelB.Size = new Size(306, 70);
            panelB.TabIndex = 13;
            // 
            // eqB
            // 
            eqB.AutoSize = true;
            eqB.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eqB.Location = new Point(178, 224);
            eqB.Name = "eqB";
            eqB.Size = new Size(81, 86);
            eqB.TabIndex = 5;
            eqB.Text = "=";
            // 
            // imgB
            // 
            imgB.Image = (Image)resources.GetObject("imgB.Image");
            imgB.Location = new Point(137, 234);
            imgB.Name = "imgB";
            imgB.Size = new Size(48, 65);
            imgB.TabIndex = 4;
            imgB.TabStop = false;
            // 
            // panelA
            // 
            panelA.Controls.Add(textA);
            panelA.Location = new Point(241, 156);
            panelA.Name = "panelA";
            panelA.Padding = new Padding(8, 5, 8, 5);
            panelA.Size = new Size(306, 70);
            panelA.TabIndex = 12;
            // 
            // textA
            // 
            textA.BorderStyle = BorderStyle.None;
            textA.Dock = DockStyle.Fill;
            textA.Font = new Font("Segoe UI", 28F);
            textA.Location = new Point(8, 5);
            textA.Margin = new Padding(0);
            textA.Multiline = true;
            textA.Name = "textA";
            textA.Size = new Size(290, 60);
            textA.TabIndex = 0;
            // 
            // eqA
            // 
            eqA.AutoSize = true;
            eqA.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eqA.Location = new Point(178, 138);
            eqA.Name = "eqA";
            eqA.Size = new Size(81, 86);
            eqA.TabIndex = 2;
            eqA.Text = "=";
            // 
            // imgDenklem
            // 
            imgDenklem.Image = (Image)resources.GetObject("imgDenklem.Image");
            imgDenklem.Location = new Point(74, 51);
            imgDenklem.Name = "imgDenklem";
            imgDenklem.Size = new Size(542, 46);
            imgDenklem.TabIndex = 0;
            imgDenklem.TabStop = false;
            // 
            // imgA
            // 
            imgA.Image = (Image)resources.GetObject("imgA.Image");
            imgA.Location = new Point(137, 148);
            imgA.Name = "imgA";
            imgA.Size = new Size(48, 65);
            imgA.TabIndex = 1;
            imgA.TabStop = false;
            // 
            // textD
            // 
            textD.BorderStyle = BorderStyle.None;
            textD.Dock = DockStyle.Fill;
            textD.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textD.Location = new Point(8, 4);
            textD.Margin = new Padding(0);
            textD.Multiline = true;
            textD.Name = "textD";
            textD.Size = new Size(290, 62);
            textD.TabIndex = 4;
            // 
            // textC
            // 
            textC.BorderStyle = BorderStyle.None;
            textC.Dock = DockStyle.Fill;
            textC.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textC.Location = new Point(8, 4);
            textC.Margin = new Padding(0);
            textC.Multiline = true;
            textC.Name = "textC";
            textC.Size = new Size(290, 62);
            textC.TabIndex = 3;
            // 
            // textB
            // 
            textB.BorderStyle = BorderStyle.None;
            textB.Dock = DockStyle.Fill;
            textB.Font = new Font("Segoe UI", 27.75F);
            textB.Location = new Point(8, 4);
            textB.Multiline = true;
            textB.Name = "textB";
            textB.Size = new Size(290, 62);
            textB.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(767, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // Denklemler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 825);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(denklemTipi);
            Controls.Add(comboBox1);
            Name = "Denklemler";
            Text = "Denklemler";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelD.ResumeLayout(false);
            panelD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgD).EndInit();
            panelC.ResumeLayout(false);
            panelC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgC).EndInit();
            panelB.ResumeLayout(false);
            panelB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgB).EndInit();
            panelA.ResumeLayout(false);
            panelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgDenklem).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label denklemTipi;
        private Panel panel1;
        private PictureBox imgA;
        private PictureBox imgDenklem;
        private Label eqA;
        private TextBox textA;
        private TextBox textD;
        private Label eqD;
        private PictureBox imgD;
        private TextBox textC;
        private Label eqC;
        private PictureBox imgC;
        private TextBox textB;
        private Label eqB;
        private PictureBox imgB;
        private Button btnDenklemCoz;
        private System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(Properties.Resources));
        private TextBox textBox1;
        private Panel panelA;
        private Panel panelD;
        private Panel panelC;
        private Panel panelB;
    }
}
