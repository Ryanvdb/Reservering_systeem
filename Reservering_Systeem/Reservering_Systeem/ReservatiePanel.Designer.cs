namespace Reservering_Systeem
{
    partial class ReservatiePanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TBmodel = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TBinleverdatum = new System.Windows.Forms.TextBox();
            this.TBnaam = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.TBmodel);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.TBinleverdatum);
            this.panel1.Controls.Add(this.TBnaam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 60);
            this.panel1.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(3, 22);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(78, 13);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Model";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 13);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Naam";
            // 
            // TBmodel
            // 
            this.TBmodel.BackColor = System.Drawing.SystemColors.Control;
            this.TBmodel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBmodel.Location = new System.Drawing.Point(87, 22);
            this.TBmodel.Name = "TBmodel";
            this.TBmodel.Size = new System.Drawing.Size(179, 13);
            this.TBmodel.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(3, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 13);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Inlever Datum";
            // 
            // TBinleverdatum
            // 
            this.TBinleverdatum.BackColor = System.Drawing.SystemColors.Control;
            this.TBinleverdatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBinleverdatum.Location = new System.Drawing.Point(87, 41);
            this.TBinleverdatum.Name = "TBinleverdatum";
            this.TBinleverdatum.Size = new System.Drawing.Size(179, 13);
            this.TBinleverdatum.TabIndex = 1;
            // 
            // TBnaam
            // 
            this.TBnaam.BackColor = System.Drawing.SystemColors.Control;
            this.TBnaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBnaam.Location = new System.Drawing.Point(87, 3);
            this.TBnaam.Name = "TBnaam";
            this.TBnaam.Size = new System.Drawing.Size(179, 13);
            this.TBnaam.TabIndex = 0;
            // 
            // ReservatiePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReservatiePanel";
            this.Size = new System.Drawing.Size(269, 60);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TBinleverdatum;
        private System.Windows.Forms.TextBox TBnaam;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TBmodel;
    }
}
