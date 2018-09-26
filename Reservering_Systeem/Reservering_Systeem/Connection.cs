using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace Reservering_Systeem
{
    class Connection
    {
        string connstring = "Server=localhost;Database=reservatie_systeem;Uid=root;SslMode=none";
        MySqlConnection connObj = new MySqlConnection();

        public void LoadProductData(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT * FROM `producten` WHERE `status` = 0";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ProductButton addedProduct = new ProductButton();

                    addedProduct.productId = rdr["Product_id"].ToString();
                    addedProduct.productName = rdr["naam"].ToString();
                    addedProduct.modelName = rdr["Model"].ToString();
                    addedProduct.productAge = rdr["leeftijd"].ToString();
                    addedProduct.ProductImage = img((byte[])rdr["ProductImage"]);

                    addedProduct.button.Text = addedProduct.modelName;
                    flowLayoutPanel.Controls.Add(addedProduct);
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

        public void LoadUserData(TextBox usernameTextbox, TextBox passwordTextbox, TextBox invalidTextbox, Form2 frm2)
        {
            try
            {
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT * FROM users WHERE `Leerlingnummer` = @username AND `Password` = @password";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                cmd.Parameters.AddWithValue("@username", usernameTextbox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextbox.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    invalidTextbox.Visible = false;

                    frm2.Hide();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    frm1.RtbUser.Text = rdr["Naam"].ToString();
                    Variables.UserID = rdr["User_id"].ToString();
                    int User = Convert.ToByte(Variables.UserID);
                    Variables.admin = Convert.ToByte(rdr["Admin"]);
                    MessageBox.Show(Variables.UserID);
                    if (Variables.admin == 1)
                    {
                        frm1.pictureBox.Hide();
                        frm1.specsPanel.Hide();
                        frm1.EditPanel.Show();
                        frm1.MeldingPanel.Show();
                    }
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

        public void SetReservationData(ProductButton lastButtonClicked)
        {
            try
            {
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "UPDATE producten SET `status` = 1 WHERE `Product_id` = @product_id";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                MessageBox.Show(Variables.UserID);

                cmd.Parameters.AddWithValue("@user_id", Variables.UserID);
                cmd.Parameters.AddWithValue("@product_id", lastButtonClicked.productId);
                MySqlDataReader rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connObj.Close();
            Debug.WriteLine("Done.");

            try
            {
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "INSERT INTO `reservaties`(`User_id`, `Product_id`) VALUES (@user_id,@product_id)";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                MessageBox.Show(Variables.UserID);

                cmd.Parameters.AddWithValue("@user_id", Variables.UserID);
                cmd.Parameters.AddWithValue("@product_id", lastButtonClicked.productId);
                MySqlDataReader rdr = cmd.ExecuteReader();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connObj.Close();
        }

        private Image img(byte[] b)
        {
            using(var ms = new MemoryStream(b))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
