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
    public partial class ReservatiePanel : UserControl
    {
        public string naam;
        public string ProductModel;
        public ReservatiePanel()
        {
            InitializeComponent();
        }

        public void LoadData() 
        {
            TBnaam.Text = naam;
            TBmodel.Text = ProductModel;
        }
    }
}
