﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservering_Systeem
{
    public partial class ProductButton : UserControl
    {
        public string productId;
        public string productAge;
        public string modelName;
        public string productName;
        public Image ProductImage;

        public ProductButton()
        {
            InitializeComponent();
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.nameTextbox.Text = productName;
            frm1.modelTextbox.Text = modelName;
            frm1.idTextbox.Text = productId;
            frm1.ageTextbox.Text = productAge;
            frm1.pictureBox.Image = ProductImage;
            frm1.lastbuttonclicked = this;
        }
    }
}
