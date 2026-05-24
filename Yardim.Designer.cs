namespace Denklemler
{
    partial class Yardim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yardim));
            yardimPanel = new Panel();
            yardimPanelImg = new PictureBox();
            yardimPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yardimPanelImg).BeginInit();
            SuspendLayout();
            // 
            // yardimPanel
            // 
            yardimPanel.AutoScroll = true;
            yardimPanel.Controls.Add(yardimPanelImg);
            yardimPanel.Dock = DockStyle.Fill;
            yardimPanel.Location = new Point(0, 0);
            yardimPanel.Margin = new Padding(6);
            yardimPanel.Name = "yardimPanel";
            yardimPanel.Size = new Size(2177, 1444);
            yardimPanel.TabIndex = 0;
            // 
            // yardimPanelImg
            // 
            yardimPanelImg.Image = Properties.Resources.yardim_kilavuz;
            yardimPanelImg.Location = new Point(-500, 0);
            yardimPanelImg.Margin = new Padding(6);
            yardimPanelImg.Name = "yardimPanelImg";
            yardimPanelImg.Size = new Size(3500, 18158);
            yardimPanelImg.SizeMode = PictureBoxSizeMode.Zoom;
            yardimPanelImg.TabIndex = 0;
            yardimPanelImg.TabStop = false;
            // 
            // Yardim
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2177, 1444);
            Controls.Add(yardimPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Yardim";
            StartPosition = FormStartPosition.Manual;
            Text = "Yardım";
            FormClosing += Yardim_FormClosing;
            yardimPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)yardimPanelImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel yardimPanel;
        private PictureBox yardimPanelImg;
        
    }
}