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
using MySql.Data.MySqlClient;

namespace Reservering_Systeem
{
    public partial class Form1 : Form
    {
        Connection connection = new Connection();

        public Form1()
        {
            InitializeComponent();
            if (Variables.admin == 1)
            {
                connection.LoadMeldingData();
            }
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            connection.SetReservation();
            connection.LoadProductData();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
