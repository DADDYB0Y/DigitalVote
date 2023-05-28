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
        private Timer time;
        private TimeSpan timeEcouler;


        public Accueil()
        {
            //Initialisation
            InitializeComponent();
            InitializeTimer();   
        }

        private void InitializeTimer()
        {
            //Initialisation du temps
            time = new Timer();
            timer.Interval = 100;
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Intervall du temps a afficher
            timeEcouler = timeEcouler.Subtract(TimeSpan.FromMilliseconds(timer.Interval));
            UpdateTimeLabel();
            if (timeEcouler <= TimeSpan.Zero)
            {
                timer.Stop();
                MessageBox.Show("Le Vote est terminé!");
                //Griser le bouton voter
                btn__Vote.Enabled = false;
            }
        }

        private void UpdateTimeLabel()
        {
            //Affichage du chrono
            LabelTime.Text = timeEcouler.ToString(@"hh\:mm\:ss\:ff");
        }

        private void buttonLogAdmin_Click(object sender, EventArgs e)
        {
            //Ouvrir la fenetre Login Admin
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            //
        }

        private void btn__Vote_Click(object sender, EventArgs e)
        {
            //Ouvrir la fenetre Timer
            LoginVote loginVote = new LoginVote();
            loginVote.Show();
            //
        }

        private void buttonPlayTime_Click(object sender, EventArgs e)
        {
            //Ouvrir la fenetre Timer
            using (Timer timerform = new Timer())
            {
                if (timerform.ShowDialog() == DialogResult.OK)
                {
                    timeEcouler = timerform.GetTimeSpan();
                    UpdateTimeLabel();
                    timer.Start();
                }
            }
        }

        //couleur des bouttons
        private void buttonPlayTime_MouseEnter(object sender, EventArgs e)
        {
            buttonPlayTime.ForeColor = Color.White;
        }

        private void buttonPlayTime_MouseLeave(object sender, EventArgs e)
        {
            buttonPlayTime.ForeColor = Color.Gray;
        }

        private void buttonLogAdmin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogAdmin.ForeColor = Color.White;
        }

        private void buttonLogAdmin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogAdmin.ForeColor = Color.Gray;
        }

        private void btn__Vote_MouseEnter(object sender, EventArgs e)
        {
            btn__Vote.ForeColor = Color.White;
        }

        private void btn__Vote_MouseLeave(object sender, EventArgs e)
        {
            btn__Vote.ForeColor = Color.Gray;
        }

    }   
}
