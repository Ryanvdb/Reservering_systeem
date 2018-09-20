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
            this.availableProductPanel = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.reservationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // specsPanel
            // 
            this.specsPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.specsPanel.Location = new System.Drawing.Point(1564, 103);
            this.specsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specsPanel.Name = "specsPanel";
            this.specsPanel.Size = new System.Drawing.Size(325, 761);
            this.specsPanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(264, 103);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1293, 761);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // availableProductPanel
            // 
            this.availableProductPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.availableProductPanel.Location = new System.Drawing.Point(264, 870);
            this.availableProductPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableProductPanel.Name = "availableProductPanel";
            this.availableProductPanel.Size = new System.Drawing.Size(1293, 151);
            this.availableProductPanel.TabIndex = 2;
            // 
            // productPanel
            // 
            this.productPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productPanel.Location = new System.Drawing.Point(12, 103);
            this.productPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(245, 917);
            this.productPanel.TabIndex = 2;
            // 
            // bannerPanel
            // 
            this.bannerPanel.Location = new System.Drawing.Point(12, 12);
            this.bannerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(1547, 86);
            this.bannerPanel.TabIndex = 3;
            // 
            // accountPanel
            // 
            this.accountPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountPanel.Location = new System.Drawing.Point(1564, 12);
            this.accountPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(325, 86);
            this.accountPanel.TabIndex = 4;
            // 
            // reservationButton
            // 
            this.reservationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationButton.Location = new System.Drawing.Point(1564, 967);
            this.reservationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(267, 54);
            this.reservationButton.TabIndex = 5;
            this.reservationButton.Text = "Reserveren";
            this.reservationButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Location = new System.Drawing.Point(1836, 967);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 54);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 1033);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reservationButton);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.bannerPanel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.availableProductPanel);
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
        private System.Windows.Forms.Panel availableProductPanel;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Button backButton;
    }
}
