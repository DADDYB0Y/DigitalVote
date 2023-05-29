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

        private void btn__ValidAdmin_Click(object sender, EventArgs e)
        {
            //Ouvrir la fenetre Login Admin
            Admin adminform = new Admin();
            adminform.Show();
            //
        }

        private void btn__ValidAdmin_MouseEnter(object sender, EventArgs e)
        {
            btn__ValidAdmin.ForeColor = Color.White;
        }

        private void btn__ValidAdmin_MouseLeave(object sender, EventArgs e)
        {
            btn__ValidAdmin.ForeColor = Color.Black;
        }

        private void btn__Capture_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox__cameraAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btn__Capture_MouseEnter(object sender, EventArgs e)
        {
            btn__Capture.ForeColor = Color.White;
        }

        private void btn__Capture_MouseLeave(object sender, EventArgs e)
        {
            btn__Capture.ForeColor = Color.Black;
        }
    }
}
