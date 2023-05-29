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
    public partial class LoginVote : Form
    {
        public LoginVote()
        {
            InitializeComponent();
        }

        private void btn__ValidVote_MouseEnter(object sender, EventArgs e)
        {
            btn__ValidVote.ForeColor = Color.White;
        }

        private void btn__ValidVote_MouseLeave(object sender, EventArgs e)
        {
            btn__ValidVote.ForeColor = Color.Black;
        }

        private void btn__ValidVote_Click(object sender, EventArgs e)
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
