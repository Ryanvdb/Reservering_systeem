using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace Reservering_Systeem
{
    class Connection
    {
        List<Product> productList = new List<Product>();

        string connstring = "Server=localhost;Database=reservatie_systeem;Uid=root;SslMode=none";
        MySqlConnection connObj;

        public void LoadData(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                connObj = new MySqlConnection(connstring);
                Debug.WriteLine("Connecting to MySQL...");
                connObj.Open();

                string sql = "SELECT * FROM `producten`";
                MySqlCommand cmd = new MySqlCommand(sql, connObj);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Product addedProduct = new Product();

                    for (int j = 0; j < 4; j++)
                    {
                        addedProduct.productId = rdr["Product_id"].ToString();
                        addedProduct.productAge = rdr["Naam"].ToString();
                        addedProduct.modelName = rdr["Model"].ToString();
                        addedProduct.productName = rdr["Leeftijd"].ToString();
                    }

                    addedProduct.usercontrolButton.button.Text = addedProduct.modelName;
                    flowLayoutPanel.Controls.Add(addedProduct.usercontrolButton);
                    productList.Add(addedProduct);
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

    public class Product
    {
        public string productId;
        public string productAge;
        public string modelName;
        public string productName;

        public ProductButton usercontrolButton = new ProductButton();
    }
}
