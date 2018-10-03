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
        public string productId;
        public string productAge;
        public string modelName;
        public string productName;
        public string productStatus;
        public Image ProductImage;

        public ProductButton()
        {
            InitializeComponent();
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            if (Variables.admin == 1)
            {
                Variables.frm1.editNameTextbox.Text = productName;
                Variables.frm1.editModelTextbox.Text = modelName;
                Variables.frm1.editAgeTextbox.Text = productAge;
                Variables.frm1.editStatusTexbox.Text = productStatus;
            }
            else
            {
                Variables.frm1.nameTextbox.Text = productName;
                Variables.frm1.modelTextbox.Text = modelName;
                Variables.frm1.idTextbox.Text = productId;
                Variables.frm1.ageTextbox.Text = productAge;
                Variables.frm1.pictureBox.Image = ProductImage;
            }

            Variables.frm1.specsPanel.Show();
            Variables.lastButtonClicked = this;
        }
    }
}
