using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Accueil : Form
    {
        private int heures;
        private int minutes;
        private int secondes;
        private int millisecondes;

        public Accueil(int heures, int minutes, int secondes, int millisecondes)
        {
            //Initialisation
            InitializeComponent();
            this.heures = heures;
            this.minutes = minutes;
            this.secondes = secondes;
            this.millisecondes = millisecondes;
            //Affichages
            LabelHeures.Text = heures.ToString();
            LabelMinutes.Text = minutes.ToString();
            LabelSecondes.Text = secondes.ToString();
            LabelMillisecondes.Text = millisecondes.ToString();

        }

        private void buttonLogAdmin_Click(object sender, EventArgs e)
        {
            //Ouvrir la fenetre Login Admin
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            //
        }

        private void buttonVote_Click(object sender, EventArgs e)
        {
            //Ouvrir la fenetre Timer
            LoginVote loginVote = new LoginVote();
            loginVote.Show();
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonPlayTime_Click(object sender, EventArgs e)
        {
            //Ouvrir la fenetre Timer
            Timer timerform = new Timer();
            timerform.Show();
            //
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LabelSeparation3_Click(object sender, EventArgs e)
        {

        }

        private void LabelSeconde_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LabelHeures_Click(object sender, EventArgs e)
        {

        }
    }   
}
