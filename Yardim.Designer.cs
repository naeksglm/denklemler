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
            yardimPanel.Name = "yardimPanel";
            yardimPanel.Size = new Size(1172, 677);
            yardimPanel.TabIndex = 0;
            // 
            // yardimPanelImg
            // 
            yardimPanelImg.Image =Properties.Resources.yardim_kilavuz;
            yardimPanelImg.Location = new Point(0, 0);
            yardimPanelImg.Name = "yardimPanelImg";
            yardimPanelImg.Size = new Size(1154, 5987);
            yardimPanelImg.SizeMode = PictureBoxSizeMode.AutoSize;
            yardimPanelImg.TabIndex = 0;
            yardimPanelImg.TabStop = false;
            // 
            // Yardim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 677);
            Controls.Add(yardimPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Yardim";
            Text = "Yardım";
            FormClosing += Yardim_FormClosing;
            yardimPanel.ResumeLayout(false);
            yardimPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yardimPanelImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel yardimPanel;
        private PictureBox yardimPanelImg;
        
    }
}