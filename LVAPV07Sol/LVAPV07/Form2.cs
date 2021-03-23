using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAPV07
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bttup_Click(object sender, EventArgs e)
        {
            pctScorpion.Location = new Point(pctScorpion.Location.X, pctScorpion.Location.Y - 1);
        }

        private void bttderecha_Click(object sender, EventArgs e)
        {
            pctScorpion.Location = new Point(pctScorpion.Location.X + 1, pctScorpion.Location.Y);
        }

        private void bttAbajo_Click(object sender, EventArgs e)
        {
            pctScorpion.Location = new Point(pctScorpion.Location.X, pctScorpion.Location.Y + 1);
        }

        private void bttizquierda_Click(object sender, EventArgs e)
        {
            
            pctScorpion.Location = new Point(pctScorpion.Location.X - 1, pctScorpion.Location.Y);
        }
    }
}
