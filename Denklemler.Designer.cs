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
            denklemPanel = new Panel();
            katsayi_Label = new Label();
            cozum_Butonu = new Button();
            panel_katsayi_Giris_D = new Panel();
            katsayi_Giris_D = new TextBox();
            labelEsittirIsareti_D = new Label();
            resim_D_Harfi = new PictureBox();
            panel_katsayi_Giris_C = new Panel();
            katsayi_Giris_C = new TextBox();
            labelEsittirIsareti_C = new Label();
            resim_C_Harfi = new PictureBox();
            panel_katsayi_Giris_B = new Panel();
            katsayi_Giris_B = new TextBox();
            labelEsittirIsareti_B = new Label();
            resim_B_Harfi = new PictureBox();
            panel_katsayi_Giris_A = new Panel();
            katsayi_Giris_A = new TextBox();
            labelEsittirIsareti_A = new Label();
            imgDenklem = new PictureBox();
            resim_A_Harfi = new PictureBox();
            temizle_Butonu = new Button();
            denklem_Cozumu_Panel = new Panel();
            denklemCozumBaslik_Label = new Label();
            cozumX1 = new PictureBox();
            cozum1_label = new Label();
            cozumX3 = new PictureBox();
            cozumX2 = new PictureBox();
            cozumX = new PictureBox();
            cozum2_label = new Label();
            cozum3_label = new Label();
            yardim_Buton_resmi = new PictureBox();
            denklemPanel.SuspendLayout();
            panel_katsayi_Giris_D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resim_D_Harfi).BeginInit();
            panel_katsayi_Giris_C.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resim_C_Harfi).BeginInit();
            panel_katsayi_Giris_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resim_B_Harfi).BeginInit();
            panel_katsayi_Giris_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgDenklem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resim_A_Harfi).BeginInit();
            denklem_Cozumu_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cozumX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cozumX3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cozumX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cozumX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yardim_Buton_resmi).BeginInit();
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
            denklemPanel.BackColor = Color.Transparent;
            denklemPanel.BorderStyle = BorderStyle.FixedSingle;
            denklemPanel.Controls.Add(katsayi_Label);
            denklemPanel.Controls.Add(cozum_Butonu);
            denklemPanel.Controls.Add(panel_katsayi_Giris_D);
            denklemPanel.Controls.Add(labelEsittirIsareti_D);
            denklemPanel.Controls.Add(resim_D_Harfi);
            denklemPanel.Controls.Add(panel_katsayi_Giris_C);
            denklemPanel.Controls.Add(labelEsittirIsareti_C);
            denklemPanel.Controls.Add(resim_C_Harfi);
            denklemPanel.Controls.Add(panel_katsayi_Giris_B);
            denklemPanel.Controls.Add(labelEsittirIsareti_B);
            denklemPanel.Controls.Add(resim_B_Harfi);
            denklemPanel.Controls.Add(panel_katsayi_Giris_A);
            denklemPanel.Controls.Add(labelEsittirIsareti_A);
            denklemPanel.Controls.Add(imgDenklem);
            denklemPanel.Controls.Add(resim_A_Harfi);
            denklemPanel.Location = new Point(22, 110);
            denklemPanel.Margin = new Padding(6);
            denklemPanel.Name = "denkemPanel";
            denklemPanel.Size = new Size(1303, 1239);
            denklemPanel.TabIndex = 2;
            // 
            // katsayi_Label
            // 
            katsayi_Label.AutoSize = true;
            katsayi_Label.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            katsayi_Label.Location = new Point(38, 136);
            katsayi_Label.Margin = new Padding(6, 0, 6, 0);
            katsayi_Label.Name = "katsayiLabel";
            katsayi_Label.Size = new Size(1177, 77);
            katsayi_Label.TabIndex = 14;
            katsayi_Label.Text = "Lütfen denklem katsayı değerlerini giriniz:";
            // 
            // cozum_Butonu
            // 
            cozum_Butonu.BackColor = Color.Lime;
            cozum_Butonu.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cozum_Butonu.Location = new Point(254, 1037);
            cozum_Butonu.Margin = new Padding(6);
            cozum_Butonu.Name = "btnDenklemCoz";
            cozum_Butonu.Size = new Size(761, 148);
            cozum_Butonu.TabIndex = 5;
            cozum_Butonu.Text = "Çözüm";
            cozum_Butonu.UseVisualStyleBackColor = false;
            cozum_Butonu.Click += btnDenklemCoz_Click;
            // 
            // panel_katsayi_Giris_D
            // 
            panel_katsayi_Giris_D.Controls.Add(katsayi_Giris_D);
            panel_katsayi_Giris_D.Location = new Point(448, 834);
            panel_katsayi_Giris_D.Margin = new Padding(6);
            panel_katsayi_Giris_D.Name = "panelD";
            panel_katsayi_Giris_D.Padding = new Padding(15, 9, 15, 9);
            panel_katsayi_Giris_D.Size = new Size(568, 149);
            panel_katsayi_Giris_D.TabIndex = 6;
            // 
            // katsayi_Giris_D
            // 
            katsayi_Giris_D.BorderStyle = BorderStyle.FixedSingle;
            katsayi_Giris_D.Dock = DockStyle.Fill;
            katsayi_Giris_D.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            katsayi_Giris_D.Location = new Point(15, 9);
            katsayi_Giris_D.Margin = new Padding(0);
            katsayi_Giris_D.Multiline = true;
            katsayi_Giris_D.Name = "textD";
            katsayi_Giris_D.Size = new Size(538, 131);
            katsayi_Giris_D.TabIndex = 4;
            katsayi_Giris_D.TextChanged += metinKontrol;
            katsayi_Giris_D.KeyPress += sayiKontrol;
            // 
            // labelEsittirIsareti_D
            // 
            labelEsittirIsareti_D.AutoSize = true;
            labelEsittirIsareti_D.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelEsittirIsareti_D.Location = new Point(331, 795);
            labelEsittirIsareti_D.Margin = new Padding(6, 0, 6, 0);
            labelEsittirIsareti_D.Name = "eqD";
            labelEsittirIsareti_D.Size = new Size(160, 170);
            labelEsittirIsareti_D.TabIndex = 11;
            labelEsittirIsareti_D.Text = "=";
            // 
            // resim_D_Harfi
            // 
            resim_D_Harfi.Image = (Image)resources.GetObject("imgD.Image");
            resim_D_Harfi.Location = new Point(254, 817);
            resim_D_Harfi.Margin = new Padding(6);
            resim_D_Harfi.Name = "imgD";
            resim_D_Harfi.Size = new Size(89, 139);
            resim_D_Harfi.SizeMode = PictureBoxSizeMode.Zoom;
            resim_D_Harfi.TabIndex = 10;
            resim_D_Harfi.TabStop = false;
            // 
            // panel_katsayi_Giris_C
            // 
            panel_katsayi_Giris_C.Controls.Add(katsayi_Giris_C);
            panel_katsayi_Giris_C.Location = new Point(448, 627);
            panel_katsayi_Giris_C.Margin = new Padding(6);
            panel_katsayi_Giris_C.Name = "panelC";
            panel_katsayi_Giris_C.Padding = new Padding(15, 9, 15, 9);
            panel_katsayi_Giris_C.Size = new Size(568, 149);
            panel_katsayi_Giris_C.TabIndex = 12;
            // 
            // katsayi_Giris_C
            // 
            katsayi_Giris_C.BorderStyle = BorderStyle.FixedSingle;
            katsayi_Giris_C.Dock = DockStyle.Fill;
            katsayi_Giris_C.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            katsayi_Giris_C.Location = new Point(15, 9);
            katsayi_Giris_C.Margin = new Padding(0);
            katsayi_Giris_C.Multiline = true;
            katsayi_Giris_C.Name = "textC";
            katsayi_Giris_C.Size = new Size(538, 131);
            katsayi_Giris_C.TabIndex = 3;
            katsayi_Giris_C.TextChanged += metinKontrol;
            katsayi_Giris_C.KeyPress += sayiKontrol;
            // 
            // labelEsittirIsareti_C
            // 
            labelEsittirIsareti_C.AutoSize = true;
            labelEsittirIsareti_C.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelEsittirIsareti_C.Location = new Point(331, 588);
            labelEsittirIsareti_C.Margin = new Padding(6, 0, 6, 0);
            labelEsittirIsareti_C.Name = "eqC";
            labelEsittirIsareti_C.Size = new Size(160, 170);
            labelEsittirIsareti_C.TabIndex = 8;
            labelEsittirIsareti_C.Text = "=";
            // 
            // resim_C_Harfi
            // 
            resim_C_Harfi.Image = (Image)resources.GetObject("imgC.Image");
            resim_C_Harfi.Location = new Point(254, 610);
            resim_C_Harfi.Margin = new Padding(6);
            resim_C_Harfi.Name = "imgC";
            resim_C_Harfi.Size = new Size(89, 139);
            resim_C_Harfi.SizeMode = PictureBoxSizeMode.Zoom;
            resim_C_Harfi.TabIndex = 7;
            resim_C_Harfi.TabStop = false;
            // 
            // panel_katsayi_Giris_B
            // 
            panel_katsayi_Giris_B.Controls.Add(katsayi_Giris_B);
            panel_katsayi_Giris_B.Location = new Point(448, 443);
            panel_katsayi_Giris_B.Margin = new Padding(6);
            panel_katsayi_Giris_B.Name = "panelB";
            panel_katsayi_Giris_B.Padding = new Padding(15, 9, 15, 9);
            panel_katsayi_Giris_B.Size = new Size(568, 149);
            panel_katsayi_Giris_B.TabIndex = 13;
            // 
            // katsayi_Giris_B
            // 
            katsayi_Giris_B.BorderStyle = BorderStyle.FixedSingle;
            katsayi_Giris_B.Dock = DockStyle.Fill;
            katsayi_Giris_B.Font = new Font("Segoe UI", 27.75F);
            katsayi_Giris_B.Location = new Point(15, 9);
            katsayi_Giris_B.Margin = new Padding(6);
            katsayi_Giris_B.Multiline = true;
            katsayi_Giris_B.Name = "textB";
            katsayi_Giris_B.Size = new Size(538, 131);
            katsayi_Giris_B.TabIndex = 0;
            katsayi_Giris_B.TextChanged += metinKontrol;
            katsayi_Giris_B.KeyPress += sayiKontrol;
            // 
            // labelEsittirIsareti_B
            // 
            labelEsittirIsareti_B.AutoSize = true;
            labelEsittirIsareti_B.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelEsittirIsareti_B.Location = new Point(331, 405);
            labelEsittirIsareti_B.Margin = new Padding(6, 0, 6, 0);
            labelEsittirIsareti_B.Name = "eqB";
            labelEsittirIsareti_B.Size = new Size(160, 170);
            labelEsittirIsareti_B.TabIndex = 5;
            labelEsittirIsareti_B.Text = "=";
            // 
            // resim_B_Harfi
            // 
            resim_B_Harfi.Image = (Image)resources.GetObject("imgB.Image");
            resim_B_Harfi.Location = new Point(254, 426);
            resim_B_Harfi.Margin = new Padding(6);
            resim_B_Harfi.Name = "imgB";
            resim_B_Harfi.Size = new Size(89, 139);
            resim_B_Harfi.SizeMode = PictureBoxSizeMode.Zoom;
            resim_B_Harfi.TabIndex = 4;
            resim_B_Harfi.TabStop = false;
            // 
            // panel_katsayi_Giris_A
            // 
            panel_katsayi_Giris_A.Controls.Add(katsayi_Giris_A);
            panel_katsayi_Giris_A.Location = new Point(448, 260);
            panel_katsayi_Giris_A.Margin = new Padding(6);
            panel_katsayi_Giris_A.Name = "panelA";
            panel_katsayi_Giris_A.Padding = new Padding(15, 11, 15, 11);
            panel_katsayi_Giris_A.Size = new Size(568, 149);
            panel_katsayi_Giris_A.TabIndex = 12;
            // 
            // katsayi_Giris_A
            // 
            katsayi_Giris_A.BackColor = Color.White;
            katsayi_Giris_A.BorderStyle = BorderStyle.FixedSingle;
            katsayi_Giris_A.Dock = DockStyle.Fill;
            katsayi_Giris_A.Font = new Font("Segoe UI", 28F);
            katsayi_Giris_A.Location = new Point(15, 11);
            katsayi_Giris_A.Margin = new Padding(0);
            katsayi_Giris_A.Multiline = true;
            katsayi_Giris_A.Name = "textA";
            katsayi_Giris_A.Size = new Size(538, 127);
            katsayi_Giris_A.TabIndex = 0;
            katsayi_Giris_A.TextChanged += metinKontrol;
            katsayi_Giris_A.KeyPress += sayiKontrol;
            // 
            // labelEsittirIsareti_A
            // 
            labelEsittirIsareti_A.AutoSize = true;
            labelEsittirIsareti_A.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelEsittirIsareti_A.Location = new Point(331, 221);
            labelEsittirIsareti_A.Margin = new Padding(6, 0, 6, 0);
            labelEsittirIsareti_A.Name = "eqA";
            labelEsittirIsareti_A.Size = new Size(160, 170);
            labelEsittirIsareti_A.TabIndex = 2;
            labelEsittirIsareti_A.Text = "=";
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
            // resim_A_Harfi
            // 
            resim_A_Harfi.Image = (Image)resources.GetObject("imgA.Image");
            resim_A_Harfi.Location = new Point(254, 243);
            resim_A_Harfi.Margin = new Padding(6);
            resim_A_Harfi.Name = "imgA";
            resim_A_Harfi.Size = new Size(89, 139);
            resim_A_Harfi.SizeMode = PictureBoxSizeMode.Zoom;
            resim_A_Harfi.TabIndex = 1;
            resim_A_Harfi.TabStop = false;
            // 
            // temizle_Butonu
            // 
            temizle_Butonu.BackColor = Color.Gold;
            temizle_Butonu.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            temizle_Butonu.Location = new Point(420, 1037);
            temizle_Butonu.Margin = new Padding(6);
            temizle_Butonu.Name = "btnTemizle";
            temizle_Butonu.Size = new Size(526, 148);
            temizle_Butonu.TabIndex = 15;
            temizle_Butonu.Text = "Temizle";
            temizle_Butonu.UseVisualStyleBackColor = false;
            temizle_Butonu.Click += btnTemizle_Click;
            // 
            // denklem_Cozumu_Panel
            // 
            denklem_Cozumu_Panel.BorderStyle = BorderStyle.FixedSingle;
            denklem_Cozumu_Panel.Controls.Add(temizle_Butonu);
            denklem_Cozumu_Panel.Controls.Add(denklemCozumBaslik_Label);
            denklem_Cozumu_Panel.Controls.Add(cozumX1);
            denklem_Cozumu_Panel.Controls.Add(cozum1_label);
            denklem_Cozumu_Panel.Controls.Add(cozumX3);
            denklem_Cozumu_Panel.Controls.Add(cozumX2);
            denklem_Cozumu_Panel.Controls.Add(cozumX);
            denklem_Cozumu_Panel.Controls.Add(cozum2_label);
            denklem_Cozumu_Panel.Controls.Add(cozum3_label);
            denklem_Cozumu_Panel.Location = new Point(1357, 110);
            denklem_Cozumu_Panel.Margin = new Padding(6);
            denklem_Cozumu_Panel.Name = "denklemCozumu";
            denklem_Cozumu_Panel.Size = new Size(1222, 1239);
            denklem_Cozumu_Panel.TabIndex = 3;
            // 
            // denklemCozumBaslik_Label
            // 
            denklemCozumBaslik_Label.AutoSize = true;
            denklemCozumBaslik_Label.BorderStyle = BorderStyle.FixedSingle;
            denklemCozumBaslik_Label.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            denklemCozumBaslik_Label.Location = new Point(266, -20);
            denklemCozumBaslik_Label.Margin = new Padding(6, 0, 6, 0);
            denklemCozumBaslik_Label.Name = "denklemCozumLabel";
            denklemCozumBaslik_Label.Size = new Size(828, 130);
            denklemCozumBaslik_Label.TabIndex = 7;
            denklemCozumBaslik_Label.Text = "Denklem Çözümü";
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
            // cozum1_label
            // 
            cozum1_label.AutoSize = true;
            cozum1_label.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cozum1_label.Location = new Point(394, 260);
            cozum1_label.Margin = new Padding(6, 0, 6, 0);
            cozum1_label.Name = "cozum1";
            cozum1_label.Size = new Size(0, 168);
            cozum1_label.TabIndex = 3;
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
            cozumX.SizeMode = PictureBoxSizeMode.Zoom;
            cozumX.TabIndex = 0;
            cozumX.TabStop = false;
            // 
            // cozum2_label
            // 
            cozum2_label.AutoSize = true;
            cozum2_label.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cozum2_label.Location = new Point(394, 486);
            cozum2_label.Margin = new Padding(6, 0, 6, 0);
            cozum2_label.Name = "cozum2";
            cozum2_label.Size = new Size(0, 168);
            cozum2_label.TabIndex = 4;
            // 
            // cozum3_label
            // 
            cozum3_label.AutoSize = true;
            cozum3_label.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cozum3_label.Location = new Point(394, 714);
            cozum3_label.Margin = new Padding(6, 0, 6, 0);
            cozum3_label.Name = "cozum3";
            cozum3_label.Size = new Size(0, 168);
            cozum3_label.TabIndex = 5;
            // 
            // yardim_Buton_resmi
            // 
            yardim_Buton_resmi.Image = Properties.Resources.yardim_1;
            yardim_Buton_resmi.Location = new Point(2459, -20);
            yardim_Buton_resmi.Margin = new Padding(6);
            yardim_Buton_resmi.Name = "yardimImg";
            yardim_Buton_resmi.Size = new Size(123, 149);
            yardim_Buton_resmi.SizeMode = PictureBoxSizeMode.Zoom;
            yardim_Buton_resmi.TabIndex = 4;
            yardim_Buton_resmi.TabStop = false;
            yardim_Buton_resmi.Click += yardimImg_Click;
            // 
            // Denklemler
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2628, 1378);
            Controls.Add(yardim_Buton_resmi);
            Controls.Add(denklem_Cozumu_Panel);
            Controls.Add(denklemPanel);
            Controls.Add(denklemListComboBox);
            Controls.Add(denklemTipi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Denklemler";
            StartPosition = FormStartPosition.Manual;
            Text = "Denklemler";
            denklemPanel.ResumeLayout(false);
            denklemPanel.PerformLayout();
            panel_katsayi_Giris_D.ResumeLayout(false);
            panel_katsayi_Giris_D.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resim_D_Harfi).EndInit();
            panel_katsayi_Giris_C.ResumeLayout(false);
            panel_katsayi_Giris_C.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resim_C_Harfi).EndInit();
            panel_katsayi_Giris_B.ResumeLayout(false);
            panel_katsayi_Giris_B.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resim_B_Harfi).EndInit();
            panel_katsayi_Giris_A.ResumeLayout(false);
            panel_katsayi_Giris_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgDenklem).EndInit();
            ((System.ComponentModel.ISupportInitialize)resim_A_Harfi).EndInit();
            denklem_Cozumu_Panel.ResumeLayout(false);
            denklem_Cozumu_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cozumX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cozumX3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cozumX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cozumX).EndInit();
            ((System.ComponentModel.ISupportInitialize)yardim_Buton_resmi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox denklemListComboBox;
        private Label denklemTipi;
        private Panel denklemPanel;
        private PictureBox resim_A_Harfi;
        private PictureBox imgDenklem;
        private Label labelEsittirIsareti_A;
        private TextBox katsayi_Giris_A;
        private TextBox katsayi_Giris_D;
        private Label labelEsittirIsareti_D;
        private PictureBox resim_D_Harfi;
        private TextBox katsayi_Giris_C;
        private Label labelEsittirIsareti_C;
        private PictureBox resim_C_Harfi;
        private TextBox katsayi_Giris_B;
        private Label labelEsittirIsareti_B;
        private PictureBox resim_B_Harfi;
        private Button cozum_Butonu;
        //private System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(Properties.Resources));
        private Panel panel_katsayi_Giris_A;
        private Panel panel_katsayi_Giris_D;
        private Panel panel_katsayi_Giris_C;
        private Panel panel_katsayi_Giris_B;
        private Panel denklem_Cozumu_Panel;
        private Label cozum1_label;
        private PictureBox cozumX3;
        private PictureBox cozumX2;
        private PictureBox cozumX;
        private Label cozum3_label;
        private Label cozum2_label;
        private PictureBox cozumX1;
        private Label denklemCozumBaslik_Label;
        private Label katsayi_Label;
        private Button temizle_Butonu;
        private PictureBox yardim_Buton_resmi;
    }
}
