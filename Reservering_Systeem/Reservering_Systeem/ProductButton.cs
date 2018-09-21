using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservering_Systeem
{
    public partial class ProductButton : UserControl
    {
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];

        public string productId;
        public string productAge;
        public string modelName;
        public string productName;

        public ProductButton()
        {
            InitializeComponent();
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(productName + " / " + modelName + " / " + productId + " / " + productAge);
        }
    }
}
