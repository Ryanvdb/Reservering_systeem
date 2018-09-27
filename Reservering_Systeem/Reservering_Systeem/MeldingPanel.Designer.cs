namespace Reservering_Systeem
{
    partial class MeldingPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_ReserveringID = new System.Windows.Forms.TextBox();
            this.TB_Status = new System.Windows.Forms.TextBox();
            this.TB_InleveringDatum = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_ReserveringID
            // 
            this.TB_ReserveringID.BackColor = System.Drawing.SystemColors.Control;
            this.TB_ReserveringID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ReserveringID.Location = new System.Drawing.Point(113, 3);
            this.TB_ReserveringID.Name = "TB_ReserveringID";
            this.TB_ReserveringID.Size = new System.Drawing.Size(100, 13);
            this.TB_ReserveringID.TabIndex = 0;
            // 
            // TB_Status
            // 
            this.TB_Status.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Status.Location = new System.Drawing.Point(113, 22);
            this.TB_Status.Name = "TB_Status";
            this.TB_Status.Size = new System.Drawing.Size(100, 13);
            this.TB_Status.TabIndex = 1;
            // 
            // TB_InleveringDatum
            // 
            this.TB_InleveringDatum.BackColor = System.Drawing.SystemColors.Control;
            this.TB_InleveringDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_InleveringDatum.Location = new System.Drawing.Point(113, 41);
            this.TB_InleveringDatum.Name = "TB_InleveringDatum";
            this.TB_InleveringDatum.Size = new System.Drawing.Size(100, 13);
            this.TB_InleveringDatum.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(7, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Reserverings ID";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(7, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Status";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(7, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Inlever Datum";
            // 
            // MeldingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TB_InleveringDatum);
            this.Controls.Add(this.TB_Status);
            this.Controls.Add(this.TB_ReserveringID);
            this.Name = "MeldingPanel";
            this.Size = new System.Drawing.Size(216, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox TB_ReserveringID;
        public System.Windows.Forms.TextBox TB_Status;
        public System.Windows.Forms.TextBox TB_InleveringDatum;
    }
}
