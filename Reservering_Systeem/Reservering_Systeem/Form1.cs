using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservering_Systeem
{
    public partial class Form1 : Form
    {
        string connstring = "Server=localhost;Database=reservatie;Uid=root;";
        MySqlConnection connObj;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connObj = new MySqlConnection(connstring);
                Console.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT * FROM ``";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(rdr[0]));
                    for (int i = 1; i < 3; i++)
                    {
                        item.SubItems.Add(Convert.ToString(rdr[i]));
                    }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            connObj.Close();
            Console.WriteLine("Done.");
        }
    }
}
