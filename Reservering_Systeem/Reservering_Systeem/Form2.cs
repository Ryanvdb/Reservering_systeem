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

        private void sumbitLogin_Click(object sender, EventArgs e)
        {
            GetDatabaseData();
        }

        private void GetDatabaseData()
        {
            Connection connection = new Connection();
            connection.LoadUserData(usernameTextbox, passwordTextbox, invalidTextbox, this);
        }
    }
}
