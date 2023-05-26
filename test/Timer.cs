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
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void Btn__Time_Click(object sender, EventArgs e)
        {
            //Recuperer les valeurs entrées par l'utilisateur
            int heures = (int)numericUpDownHeure.Value;
            int minutes = (int)numericUpDownMinute.Value;
            int secondes = (int)numericUpDownSeconde.Value;
            int millisecondes= (int)numericUpDownMilliseconde.Value;
            //Creer une nouvelle instance de la page Accueil et y passer les valeurs en tant que parametres
            Accueil homePage = new Accueil(heures, minutes, secondes, millisecondes);
            homePage.Show();
        }
    }
}
