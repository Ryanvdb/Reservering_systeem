namespace Reservering_Systeem
{
    partial class Form1
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
            this.specsPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.productPanel = new System.Windows.Forms.Panel();
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.reservationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // specsPanel
            // 
            this.specsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specsPanel.Location = new System.Drawing.Point(1533, 103);
            this.specsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specsPanel.Name = "specsPanel";
            this.specsPanel.Size = new System.Drawing.Size(357, 693);
            this.specsPanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Location = new System.Drawing.Point(340, 103);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1187, 693);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // productPanel
            // 
            this.productPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productPanel.Location = new System.Drawing.Point(12, 103);
            this.productPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(322, 919);
            this.productPanel.TabIndex = 2;
            // 
            // bannerPanel
            // 
            this.bannerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bannerPanel.Location = new System.Drawing.Point(12, 12);
            this.bannerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(1515, 86);
            this.bannerPanel.TabIndex = 3;
            // 
            // accountPanel
            // 
            this.accountPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountPanel.Location = new System.Drawing.Point(1533, 12);
            this.accountPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(357, 86);
            this.accountPanel.TabIndex = 4;
            // 
            // reservationButton
            // 
            this.reservationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationButton.Location = new System.Drawing.Point(1533, 968);
            this.reservationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(295, 54);
            this.reservationButton.TabIndex = 5;
            this.reservationButton.Text = "Reserveren";
            this.reservationButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1834, 968);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 54);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(340, 801);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1187, 220);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reservationButton);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.bannerPanel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.specsPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel specsPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
