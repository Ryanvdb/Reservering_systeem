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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_ReserveringID
            // 
            this.TB_ReserveringID.BackColor = System.Drawing.SystemColors.Control;
            this.TB_ReserveringID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ReserveringID.Location = new System.Drawing.Point(109, 3);
            this.TB_ReserveringID.Name = "TB_ReserveringID";
            this.TB_ReserveringID.Size = new System.Drawing.Size(100, 13);
            this.TB_ReserveringID.TabIndex = 0;
            // 
            // TB_Status
            // 
            this.TB_Status.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Status.Location = new System.Drawing.Point(109, 22);
            this.TB_Status.Name = "TB_Status";
            this.TB_Status.Size = new System.Drawing.Size(100, 13);
            this.TB_Status.TabIndex = 1;
            // 
            // TB_InleveringDatum
            // 
            this.TB_InleveringDatum.BackColor = System.Drawing.SystemColors.Control;
            this.TB_InleveringDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_InleveringDatum.Location = new System.Drawing.Point(109, 41);
            this.TB_InleveringDatum.Name = "TB_InleveringDatum";
            this.TB_InleveringDatum.Size = new System.Drawing.Size(100, 13);
            this.TB_InleveringDatum.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Reserverings ID";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(3, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Status";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(3, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Inlever Datum";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.TB_ReserveringID);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.TB_Status);
            this.panel1.Controls.Add(this.TB_InleveringDatum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 60);
            this.panel1.TabIndex = 6;
            // 
            // MeldingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MeldingPanel";
            this.Size = new System.Drawing.Size(216, 60);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox TB_ReserveringID;
        public System.Windows.Forms.TextBox TB_Status;
        public System.Windows.Forms.TextBox TB_InleveringDatum;
        private System.Windows.Forms.Panel panel1;
    }
}
