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

        public void LoadProductData()
        {
            ClearPanels(Variables.frm1.ProductenPanel.Controls.Cast<Control>().ToList(), Variables.frm1.ProductenPanel);
            ClearPanels(Variables.frm1.reservatiePanel.Controls.Cast<Control>().ToList(), Variables.frm1.reservatiePanel);
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
                    addedProduct.productStatus = rdr["Status"].ToString();

                    if (rdr["ProductImage"] != DBNull.Value)
                    {
                        addedProduct.ProductImage = img((byte[])rdr["ProductImage"]);
                    }

                    addedProduct.button.Text = addedProduct.modelName;
                    Variables.frm1.ProductenPanel.Controls.Add(addedProduct);
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

        public void LoadUserData()
        {
            bool check = false;

            try
            {
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT * FROM users WHERE `Leerlingnummer` = @username AND `Password` = @password";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                cmd.Parameters.AddWithValue("@username", Variables.frm2.usernameTextbox.Text);
                cmd.Parameters.AddWithValue("@password", Variables.frm2.passwordTextbox.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    check = true;

                    Variables.frm2.invalidTextbox.Visible = false;

                    Variables.userID = Convert.ToByte(rdr["User_id"]);
                    Variables.admin = Convert.ToByte(rdr["Admin"]);

                    Variables.frm2.Hide();
                    Variables.frm1 = new Form1();
                    Variables.frm1.Show();

                    Variables.frm1.RtbUser.Text = rdr["Naam"].ToString();

                    if (Variables.admin == 1)
                    {
                        Variables.frm1.reservatiePanel.Hide();
                        Variables.frm1.pictureBox.Hide();
                        Variables.frm1.specsPanel.Hide();
                        Variables.frm1.UpdateButton.Show();
                        Variables.frm1.CreateButton.Show();
                        Variables.frm1.DeleteButton.Show();
                        Variables.frm1.EditPanel.Show();
                        Variables.frm1.AdminPanel.Show();
                    }
                }
                else
                {
                    Variables.frm2.invalidTextbox.Visible = true;
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            connObj.Close();

            if (check)
            {
                LoadProductData();
                LoadReservationData();
            }
            Debug.WriteLine("Done.");
        }

        public void LoadReservationData()
        {
            try
            {
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT reservaties.Datum, producten.Model, producten.Naam FROM reservaties INNER JOIN producten ON reservaties.Product_id = producten.Product_id WHERE reservaties.User_id = @userId";

                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                cmd.Parameters.AddWithValue("@userId", Variables.userID);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ReservatiePanel addedPanel = new ReservatiePanel();

                    addedPanel.TBnaam.Text = rdr["Naam"].ToString();
                    addedPanel.TBmodel.Text = rdr["Model"].ToString();
                    addedPanel.TBinleverdatum.Text = rdr["Datum"].ToString();

                    Variables.frm1.reservatiePanel.Controls.Add(addedPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connObj.Close();
        }

        public void SetReservation()
        {
            try
            {
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "UPDATE producten SET `status` = 1 WHERE `Product_id` = @product_id";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);

                cmd.Parameters.AddWithValue("@user_id", Variables.userID);
                cmd.Parameters.AddWithValue("@product_id", Convert.ToByte(Variables.lastButtonClicked.productId));

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

                cmd.Parameters.AddWithValue("@user_id", Variables.userID);
                cmd.Parameters.AddWithValue("@product_id", Convert.ToByte(Variables.lastButtonClicked.productId));

                MySqlDataReader rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connObj.Close();
        }

        bool Melding = false;

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }


        public void LoadMeldingData()
        {
            try
            {
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT * FROM `reservaties` WHERE `Datum` < CURRENT_DATE";

                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MeldingPanel addedPanel = new MeldingPanel();

                    addedPanel.TB_ReserveringID.Text = rdr["Reservaties_ID"].ToString();
                    addedPanel.TB_InleveringDatum.Text = rdr["Datum"].ToString();
                    Variables.frm1.AdminPanel.Controls.Add(addedPanel);

                    if (ConvertToUnixTimestamp(DateTime.Now) > ConvertToUnixTimestamp(DateTime.Parse(rdr["Datum"].ToString())))
                    {
                        Melding = true;
                        if (Melding == true)
                        {
                            addedPanel.TB_Status.Text = "over datum";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            connObj.Close();
        }

        public void AdminUpdateProduct()
        {
            try
            {
                LoadProductData();
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "UPDATE producten SET naam = @naam, leeftijd = @leeftijd, model = @model, status = @status WHERE Product_id = @product_id";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);

                cmd.Parameters.AddWithValue("@naam", Variables.frm1.editNameTextbox.Text);
                cmd.Parameters.AddWithValue("@model", Variables.frm1.editModelTextbox.Text);
                cmd.Parameters.AddWithValue("@leeftijd", Variables.frm1.editAgeTextbox.Text);
                cmd.Parameters.AddWithValue("@status", Variables.frm1.editStatusTexbox.Text);
                //cmd.Parameters.AddWithValue("@image", Variables.frm1.editImageButton);
                cmd.Parameters.AddWithValue("@product_id", Variables.lastButtonClicked.productId);

                MySqlDataReader rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connObj.Close();
            Debug.WriteLine("Done.");
        }

        public void AdminDeleteProduct()
        {
            try
            {
                LoadProductData();
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "DELETE FROM producten WHERE Product_id = @product_id";

                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                cmd.Parameters.AddWithValue("@product_id", Variables.lastButtonClicked.productId);

                MySqlDataReader rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connObj.Close();
            Debug.WriteLine("Done.");
        }

        public void AdminInsertProduct()
        {
            try
            {
                LoadProductData();
                connObj.ConnectionString = connstring;
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "INSERT INTO producten (naam, leeftijd, model, status) VALUES (@naam, @leeftijd, @model, @status)";

                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                cmd.Parameters.AddWithValue("@naam", Variables.frm1.editNameTextbox.Text);
                cmd.Parameters.AddWithValue("@model", Variables.frm1.editModelTextbox.Text);
                cmd.Parameters.AddWithValue("@leeftijd", Variables.frm1.editAgeTextbox.Text);
                cmd.Parameters.AddWithValue("@status", Variables.frm1.editStatusTexbox.Text);
                //cmd.Parameters.AddWithValue("@image", UploadImage());

                MySqlDataReader rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connObj.Close();
            Debug.WriteLine("Done.");
        }

        private string UploadImage()
        {
            string i = Convert.ToString(Variables.image);

            return i;
        }

        private Image img(byte[] b)
        {
            using (var ms = new MemoryStream(b))
            {
                return Image.FromStream(ms);
            }
        }

        private void ClearPanels(List<Control> listControls, FlowLayoutPanel flowLayout)
        {
            foreach (Control control in listControls)
            {
                flowLayout.Controls.Remove(control);
                control.Dispose();
            }
            Variables.frm1.pictureBox.Image = null;
        }
    }
}
