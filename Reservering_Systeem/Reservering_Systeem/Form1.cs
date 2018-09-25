using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Reservering_Systeem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
            GetDatabaseData();

            Application.Run(new Form2());

        }

        private void GetDatabaseData()
        {
            Connection connection = new Connection();
            connection.LoadData(flowLayoutPanel);   
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
