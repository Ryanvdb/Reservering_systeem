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
        public Form1()
        {
            InitializeComponent();
            GetDatabaseData();
        }

        public ProductButton lastbuttonclicked;
        public string UserID;

        private void GetDatabaseData()
        {
            Connection connection = new Connection();

            //Action action = () =>
            //{
                
            //};

            connection.LoadData(flowLayoutPanel/*, action*/);   
        }

        string connstring = "Server=localhost;Database=reservatie_systeem;Uid=root;SslMode=none";
        MySqlConnection connObj;

        private void reservationButton_Click(object sender, EventArgs e)
        {
            try
            {
                connObj = new MySqlConnection(connstring);
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "UPDATE producten SET `status` = 1 WHERE `Product_id` = @product_id ";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                cmd.Parameters.AddWithValue("@product_id", lastbuttonclicked.productId);
                MySqlDataReader rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
