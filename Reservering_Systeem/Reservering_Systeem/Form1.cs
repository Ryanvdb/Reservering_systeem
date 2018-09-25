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

        public ProductButton lastButtonClicked;
        public string UserID;

        public Form1()
        {
            InitializeComponent();

            connection.LoadProductData(flowLayoutPanel);
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            connection.SetReservationData(lastButtonClicked);
        }
    }
}
