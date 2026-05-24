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
            denklemListComboBox = new ComboBox();
            denklemTipi = new Label();
            denkemPanel = new Panel();
            katsayiLabel = new Label();
            btnDenklemCoz = new Button();
            panelD = new Panel();
            textD = new TextBox();
            eqD = new Label();
            imgD = new PictureBox();
            panelC = new Panel();
            textC = new TextBox();
            eqC = new Label();
            imgC = new PictureBox();
            panelB = new Panel();
            textB = new TextBox();
            eqB = new Label();
            imgB = new PictureBox();
            panelA = new Panel();
            textA = new TextBox();
            eqA = new Label();
            imgDenklem = new PictureBox();
            imgA = new PictureBox();
            btnTemizle = new Button();
            denklemCozumu = new Panel();
            denklemCozumLabel = new Label();
            cozumX1 = new PictureBox();
            cozum1 = new Label();
            cozumX3 = new PictureBox();
            cozumX2 = new PictureBox();
            cozumX = new PictureBox();
            cozum2 = new Label();
            cozum3 = new Label();
            yardimImg = new PictureBox();
            denkemPanel.SuspendLayout();
            panelD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgD).BeginInit();
            panelC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgC).BeginInit();
            panelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgB).BeginInit();
            panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgDenklem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgA).BeginInit();
            denklemCozumu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cozumX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cozumX3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cozumX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cozumX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yardimImg).BeginInit();
            SuspendLayout();
            // 
            // denklemListComboBox
            // 
            denklemListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            denklemListComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            denklemListComboBox.FormattingEnabled = true;
            denklemListComboBox.Items.AddRange(new object[] { "Lütfen Denklem Tipini Seçiniz", "Birinci Dereceden Bir Bilinmeyenli Denklem", "İkinci Dereceden Bir Bilinmeyenli Denklem", "Üçüncü Dereceden Bir Bilinmeyenli Denklem" });
            denklemListComboBox.Location = new Point(416, 27);
            denklemListComboBox.Margin = new Padding(6);
            denklemListComboBox.Name = "denklemListComboBox";
            denklemListComboBox.Size = new Size(909, 65);
            denklemListComboBox.TabIndex = 0;
            denklemListComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // denklemTipi
            // 
            denklemTipi.AutoSize = true;
            denklemTipi.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            denklemTipi.Location = new Point(22, 10);
            denklemTipi.Margin = new Padding(6, 0, 6, 0);
            denklemTipi.Name = "denklemTipi";
            denklemTipi.Size = new Size(408, 77);
            denklemTipi.TabIndex = 1;
            denklemTipi.Text = "Denklem Tipi:";
            // 
            // denkemPanel
            // 
            denkemPanel.BackColor = Color.Transparent;
            denkemPanel.BorderStyle = BorderStyle.FixedSingle;
            denkemPanel.Controls.Add(katsayiLabel);
            denkemPanel.Controls.Add(btnDenklemCoz);
            denkemPanel.Controls.Add(panelD);
            denkemPanel.Controls.Add(eqD);
            denkemPanel.Controls.Add(imgD);
            denkemPanel.Controls.Add(panelC);
            denkemPanel.Controls.Add(eqC);
            denkemPanel.Controls.Add(imgC);
            denkemPanel.Controls.Add(panelB);
            denkemPanel.Controls.Add(eqB);
            denkemPanel.Controls.Add(imgB);
            denkemPanel.Controls.Add(panelA);
            denkemPanel.Controls.Add(eqA);
            denkemPanel.Controls.Add(imgDenklem);
            denkemPanel.Controls.Add(imgA);
            denkemPanel.Location = new Point(22, 110);
            denkemPanel.Margin = new Padding(6);
            denkemPanel.Name = "denkemPanel";
            denkemPanel.Size = new Size(1303, 1239);
            denkemPanel.TabIndex = 2;
            // 
            // katsayiLabel
            // 
            katsayiLabel.AutoSize = true;
            katsayiLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            katsayiLabel.Location = new Point(38, 136);
            katsayiLabel.Margin = new Padding(6, 0, 6, 0);
            katsayiLabel.Name = "katsayiLabel";
            katsayiLabel.Size = new Size(1177, 77);
            katsayiLabel.TabIndex = 14;
            katsayiLabel.Text = "Lütfen denklem katsayı değerlerini giriniz:";
            // 
            // btnDenklemCoz
            // 
            btnDenklemCoz.BackColor = Color.Lime;
            btnDenklemCoz.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDenklemCoz.Location = new Point(254, 1037);
            btnDenklemCoz.Margin = new Padding(6);
            btnDenklemCoz.Name = "btnDenklemCoz";
            btnDenklemCoz.Size = new Size(761, 148);
            btnDenklemCoz.TabIndex = 5;
            btnDenklemCoz.Text = "Çözüm";
            btnDenklemCoz.UseVisualStyleBackColor = false;
            btnDenklemCoz.Click += btnDenklemCoz_Click;
            // 
            // panelD
            // 
            panelD.Controls.Add(textD);
            panelD.Location = new Point(448, 834);
            panelD.Margin = new Padding(6);
            panelD.Name = "panelD";
            panelD.Padding = new Padding(15, 9, 15, 9);
            panelD.Size = new Size(568, 149);
            panelD.TabIndex = 6;
            // 
            // textD
            // 
            textD.BorderStyle = BorderStyle.FixedSingle;
            textD.Dock = DockStyle.Fill;
            textD.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textD.Location = new Point(15, 9);
            textD.Margin = new Padding(0);
            textD.Multiline = true;
            textD.Name = "textD";
            textD.Size = new Size(538, 131);
            textD.TabIndex = 4;
            textD.TextChanged += metinKontrol;
            textD.KeyPress += sayiKontrol;
            // 
            // eqD
            // 
            eqD.AutoSize = true;
            eqD.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eqD.Location = new Point(331, 795);
            eqD.Margin = new Padding(6, 0, 6, 0);
            eqD.Name = "eqD";
            eqD.Size = new Size(160, 170);
            eqD.TabIndex = 11;
            eqD.Text = "=";
            // 
            // imgD
            // 
            imgD.Image = (Image)resources.GetObject("imgD.Image");
            imgD.Location = new Point(254, 817);
            imgD.Margin = new Padding(6);
            imgD.Name = "imgD";
            imgD.Size = new Size(89, 139);
            imgD.SizeMode = PictureBoxSizeMode.Zoom;
            imgD.TabIndex = 10;
            imgD.TabStop = false;
            // 
            // panelC
            // 
            panelC.Controls.Add(textC);
            panelC.Location = new Point(448, 627);
            panelC.Margin = new Padding(6);
            panelC.Name = "panelC";
            panelC.Padding = new Padding(15, 9, 15, 9);
            panelC.Size = new Size(568, 149);
            panelC.TabIndex = 12;
            // 
            // textC
            // 
            textC.BorderStyle = BorderStyle.FixedSingle;
            textC.Dock = DockStyle.Fill;
            textC.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textC.Location = new Point(15, 9);
            textC.Margin = new Padding(0);
            textC.Multiline = true;
            textC.Name = "textC";
            textC.Size = new Size(538, 131);
            textC.TabIndex = 3;
            textC.TextChanged += metinKontrol;
            textC.KeyPress += sayiKontrol;
            // 
            // eqC
            // 
            eqC.AutoSize = true;
            eqC.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eqC.Location = new Point(331, 588);
            eqC.Margin = new Padding(6, 0, 6, 0);
            eqC.Name = "eqC";
            eqC.Size = new Size(160, 170);
            eqC.TabIndex = 8;
            eqC.Text = "=";
            // 
            // imgC
            // 
            imgC.Image = (Image)resources.GetObject("imgC.Image");
            imgC.Location = new Point(254, 610);
            imgC.Margin = new Padding(6);
            imgC.Name = "imgC";
            imgC.Size = new Size(89, 139);
            imgC.SizeMode = PictureBoxSizeMode.Zoom;
            imgC.TabIndex = 7;
            imgC.TabStop = false;
            // 
            // panelB
            // 
            panelB.Controls.Add(textB);
            panelB.Location = new Point(448, 443);
            panelB.Margin = new Padding(6);
            panelB.Name = "panelB";
            panelB.Padding = new Padding(15, 9, 15, 9);
            panelB.Size = new Size(568, 149);
            panelB.TabIndex = 13;
            // 
            // textB
            // 
            textB.BorderStyle = BorderStyle.FixedSingle;
            textB.Dock = DockStyle.Fill;
            textB.Font = new Font("Segoe UI", 27.75F);
            textB.Location = new Point(15, 9);
            textB.Margin = new Padding(6);
            textB.Multiline = true;
            textB.Name = "textB";
            textB.Size = new Size(538, 131);
            textB.TabIndex = 0;
            textB.TextChanged += metinKontrol;
            textB.KeyPress += sayiKontrol;
            // 
            // eqB
            // 
            eqB.AutoSize = true;
            eqB.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eqB.Location = new Point(331, 405);
            eqB.Margin = new Padding(6, 0, 6, 0);
            eqB.Name = "eqB";
            eqB.Size = new Size(160, 170);
            eqB.TabIndex = 5;
            eqB.Text = "=";
            // 
            // imgB
            // 
            imgB.Image = (Image)resources.GetObject("imgB.Image");
            imgB.Location = new Point(254, 426);
            imgB.Margin = new Padding(6);
            imgB.Name = "imgB";
            imgB.Size = new Size(89, 139);
            imgB.SizeMode = PictureBoxSizeMode.Zoom;
            imgB.TabIndex = 4;
            imgB.TabStop = false;
            // 
            // panelA
            // 
            panelA.Controls.Add(textA);
            panelA.Location = new Point(448, 260);
            panelA.Margin = new Padding(6);
            panelA.Name = "panelA";
            panelA.Padding = new Padding(15, 11, 15, 11);
            panelA.Size = new Size(568, 149);
            panelA.TabIndex = 12;
            // 
            // textA
            // 
            textA.BackColor = Color.White;
            textA.BorderStyle = BorderStyle.FixedSingle;
            textA.Dock = DockStyle.Fill;
            textA.Font = new Font("Segoe UI", 28F);
            textA.Location = new Point(15, 11);
            textA.Margin = new Padding(0);
            textA.Multiline = true;
            textA.Name = "textA";
            textA.Size = new Size(538, 127);
            textA.TabIndex = 0;
            textA.TextChanged += metinKontrol;
            textA.KeyPress += sayiKontrol;
            // 
            // eqA
            // 
            eqA.AutoSize = true;
            eqA.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eqA.Location = new Point(331, 221);
            eqA.Margin = new Padding(6, 0, 6, 0);
            eqA.Name = "eqA";
            eqA.Size = new Size(160, 170);
            eqA.TabIndex = 2;
            eqA.Text = "=";
            // 
            // imgDenklem
            // 
            imgDenklem.BorderStyle = BorderStyle.FixedSingle;
            imgDenklem.Image = (Image)resources.GetObject("imgDenklem.Image");
            imgDenklem.Location = new Point(31, 14);
            imgDenklem.Margin = new Padding(6);
            imgDenklem.Name = "imgDenklem";
            imgDenklem.Size = new Size(1241, 115);
            imgDenklem.SizeMode = PictureBoxSizeMode.Zoom;
            imgDenklem.TabIndex = 0;
            imgDenklem.TabStop = false;
            // 
            // imgA
            // 
            imgA.Image = (Image)resources.GetObject("imgA.Image");
            imgA.Location = new Point(254, 243);
            imgA.Margin = new Padding(6);
            imgA.Name = "imgA";
            imgA.Size = new Size(89, 139);
            imgA.SizeMode = PictureBoxSizeMode.Zoom;
            imgA.TabIndex = 1;
            imgA.TabStop = false;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Gold;
            btnTemizle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnTemizle.Location = new Point(420, 1037);
            btnTemizle.Margin = new Padding(6);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(526, 148);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // denklemCozumu
            // 
            denklemCozumu.BorderStyle = BorderStyle.FixedSingle;
            denklemCozumu.Controls.Add(btnTemizle);
            denklemCozumu.Controls.Add(denklemCozumLabel);
            denklemCozumu.Controls.Add(cozumX1);
            denklemCozumu.Controls.Add(cozum1);
            denklemCozumu.Controls.Add(cozumX3);
            denklemCozumu.Controls.Add(cozumX2);
            denklemCozumu.Controls.Add(cozumX);
            denklemCozumu.Controls.Add(cozum2);
            denklemCozumu.Controls.Add(cozum3);
            denklemCozumu.Location = new Point(1357, 110);
            denklemCozumu.Margin = new Padding(6);
            denklemCozumu.Name = "denklemCozumu";
            denklemCozumu.Size = new Size(1222, 1239);
            denklemCozumu.TabIndex = 3;
            // 
            // denklemCozumLabel
            // 
            denklemCozumLabel.AutoSize = true;
            denklemCozumLabel.BorderStyle = BorderStyle.FixedSingle;
            denklemCozumLabel.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            denklemCozumLabel.Location = new Point(266, -20);
            denklemCozumLabel.Margin = new Padding(6, 0, 6, 0);
            denklemCozumLabel.Name = "denklemCozumLabel";
            denklemCozumLabel.Size = new Size(828, 130);
            denklemCozumLabel.TabIndex = 7;
            denklemCozumLabel.Text = "Denklem Çözümü";
            // 
            // cozumX1
            // 
            cozumX1.Image = (Image)resources.GetObject("cozumX1.Image");
            cozumX1.Location = new Point(106, 281);
            cozumX1.Margin = new Padding(6);
            cozumX1.Name = "cozumX1";
            cozumX1.Size = new Size(284, 147);
            cozumX1.SizeMode = PictureBoxSizeMode.Zoom;
            cozumX1.TabIndex = 6;
            cozumX1.TabStop = false;
            // 
            // cozum1
            // 
            cozum1.AutoSize = true;
            cozum1.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cozum1.Location = new Point(394, 260);
            cozum1.Margin = new Padding(6, 0, 6, 0);
            cozum1.Name = "cozum1";
            cozum1.Size = new Size(0, 168);
            cozum1.TabIndex = 3;
            // 
            // cozumX3
            // 
            cozumX3.Image = (Image)resources.GetObject("cozumX3.Image");
            cozumX3.Location = new Point(106, 733);
            cozumX3.Margin = new Padding(6);
            cozumX3.Name = "cozumX3";
            cozumX3.Size = new Size(284, 147);
            cozumX3.SizeMode = PictureBoxSizeMode.Zoom;
            cozumX3.TabIndex = 2;
            cozumX3.TabStop = false;
            // 
            // cozumX2
            // 
            cozumX2.Image = (Image)resources.GetObject("cozumX2.Image");
            cozumX2.Location = new Point(106, 507);
            cozumX2.Margin = new Padding(6);
            cozumX2.Name = "cozumX2";
            cozumX2.Size = new Size(284, 147);
            cozumX2.SizeMode = PictureBoxSizeMode.Zoom;
            cozumX2.TabIndex = 1;
            cozumX2.TabStop = false;
            // 
            // cozumX
            // 
            cozumX.Image = (Image)resources.GetObject("cozumX.Image");
            cozumX.Location = new Point(156, 281);
            cozumX.Margin = new Padding(6);
            cozumX.Name = "cozumX";
            cozumX.Size = new Size(234, 147);
            cozumX.TabIndex = 0;
            cozumX.TabStop = false;
            // 
            // cozum2
            // 
            cozum2.AutoSize = true;
            cozum2.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cozum2.Location = new Point(394, 486);
            cozum2.Margin = new Padding(6, 0, 6, 0);
            cozum2.Name = "cozum2";
            cozum2.Size = new Size(0, 168);
            cozum2.TabIndex = 4;
            // 
            // cozum3
            // 
            cozum3.AutoSize = true;
            cozum3.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cozum3.Location = new Point(394, 714);
            cozum3.Margin = new Padding(6, 0, 6, 0);
            cozum3.Name = "cozum3";
            cozum3.Size = new Size(0, 168);
            cozum3.TabIndex = 5;
            // 
            // yardimImg
            // 
            yardimImg.Image = Properties.Resources.yardim_1;
            yardimImg.Location = new Point(2459, -20);
            yardimImg.Margin = new Padding(6);
            yardimImg.Name = "yardimImg";
            yardimImg.Size = new Size(123, 149);
            yardimImg.SizeMode = PictureBoxSizeMode.Zoom;
            yardimImg.TabIndex = 4;
            yardimImg.TabStop = false;
            yardimImg.Click += yardimImg_Click;
            // 
            // Denklemler
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2628, 1378);
            Controls.Add(yardimImg);
            Controls.Add(denklemCozumu);
            Controls.Add(denkemPanel);
            Controls.Add(denklemListComboBox);
            Controls.Add(denklemTipi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Denklemler";
            StartPosition = FormStartPosition.Manual;
            Text = "Denklemler";
            denkemPanel.ResumeLayout(false);
            denkemPanel.PerformLayout();
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
            denklemCozumu.ResumeLayout(false);
            denklemCozumu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cozumX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cozumX3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cozumX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cozumX).EndInit();
            ((System.ComponentModel.ISupportInitialize)yardimImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox denklemListComboBox;
        private Label denklemTipi;
        private Panel denkemPanel;
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
        private Panel panelA;
        private Panel panelD;
        private Panel panelC;
        private Panel panelB;
        private Panel denklemCozumu;
        private Label cozum1;
        private PictureBox cozumX3;
        private PictureBox cozumX2;
        private PictureBox cozumX;
        private Label cozum3;
        private Label cozum2;
        private PictureBox cozumX1;
        private Label denklemCozumLabel;
        private Label katsayiLabel;
        private Button btnTemizle;
        private PictureBox yardimImg;
    }
}
