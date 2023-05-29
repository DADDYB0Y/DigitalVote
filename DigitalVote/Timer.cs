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

        public TimeSpan GetTimeSpan()
        {
            //Recuperer les valeurs entrées par l'utilisateur
            int heures = (int)numericUpDownHeure.Value;
            int minutes = (int)numericUpDownMinute.Value;
            int secondes = (int)numericUpDownSeconde.Value;
            int millisecondes = (int)numericUpDownMilliseconde.Value;
            return new TimeSpan(0, heures, minutes, secondes, millisecondes);
        }

        private void Btn__Time_Click(object sender, EventArgs e)
        {
            //Valider le donnees entrees
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn__Time_MouseEnter(object sender, EventArgs e)
        {
            Btn__Time.ForeColor = Color.White;
        }

        private void Btn__Time_MouseLeave(object sender, EventArgs e)
        {
            Btn__Time.ForeColor = Color.Gray;
        }
    }
}
