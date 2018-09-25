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
        MySqlConnection connObj;

        public void LoadData(FlowLayoutPanel flowLayoutPanel/*, Action action*/)
        {
            try
            {
                connObj = new MySqlConnection(connstring);
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT * FROM `producten` WHERE `status` = 0";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //action();
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

        private Image img(byte[] b)
        {
            using(var ms = new MemoryStream(b))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
