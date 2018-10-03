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
using System.IO;

namespace Reservering_Systeem
{
    public partial class Form1 : Form
    {
        Connection connection = new Connection();

        public Form1()
        {
            InitializeComponent();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            connection.SetReservation();
            connection.LoadProductData();
            connection.LoadReservationData();
            specsPanel.Hide();
            reservatiePanel.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Variables.admin == 1)
            {
                connection.LoadMeldingData();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            specsPanel.Hide();
            reservatiePanel.Show();
            pictureBox.Image = null;
        }

        private void editImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            using (var opd = new  OpenFileDialog())
            {
                DialogResult result = opd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Variables.image = opd.OpenFile();
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            connection.AdminUpdateProduct();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connection.AdminDeleteProduct();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            connection.AdminInsertProduct();
        }
    }
}
