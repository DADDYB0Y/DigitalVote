using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void textBox__NomComplet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn__ValidAdmin_Click(object sender, EventArgs e)
        {
            //Ouvrir la fenetre Login Admin
            Admin adminform = new Admin();
            adminform.Show();
            //
        }
    }
}
