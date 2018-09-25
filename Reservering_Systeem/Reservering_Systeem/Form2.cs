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
using System.Diagnostics;

namespace Reservering_Systeem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string connstring = "Server=localhost;Database=reservatie_systeem;Uid=root;SslMode=none";
        MySqlConnection connObj;

        private void sumbitLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connObj = new MySqlConnection(connstring);
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT `Leerlingnummer`, `Password` FROM users WHERE `Leerlingnummer` = @username AND `Password` = @password";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                cmd.Parameters.AddWithValue("@username", usernameTextbox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextbox.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    invalidTextbox.Visible = false;

                    this.Hide();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                }
                else
                {
                    invalidTextbox.Visible = true;
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            connObj.Close();
            Debug.WriteLine("Done.");
            
        }
    }
}
