using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHangMan
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();//death screen
            MainGame.died += 1;
            lblAnswer.Text = "The word was " + MainGame.word;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Close();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
