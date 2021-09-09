using SomeProject.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class ComedyGold : Form
    {
        private GameClass gameplay = new GameClass();

        public ComedyGold()
        {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
        }

        private void ChangeGameMode()
        {

        }

        private void AdvanceProgressBar(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value >= 100)
            {
                buttonFinishProcess.Enabled = true;
            }
        }

        private void FinishProgressBar(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            if (gameplay.Chance > 50)
            {
                gameplay.AmountSuccess++;
            }
            else
            {
                gameplay.AmountFailed++;
            }

            // Update Algorithm

            textSuccess.Text = Convert.ToString(gameplay.AmountSuccess);
            textFailure.Text = Convert.ToString(gameplay.AmountFailed);

            buttonFinishProcess.Enabled = false;
        }

        private void UpdateProgressBar(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value >= 100)
            {
                buttonFinishProcess.Enabled = true;
            }
        }
    }
}
