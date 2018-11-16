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
    public partial class Form6 : Form
    {
        /********************************************************************************
          * *
          * *Below is an example of a function with one paramater and it returns a string
          * *
          * */
        string Dead(int score)//function used to check how many points they have and display the current points 
        {
            if (score >= 0)
            {
                return score + "Points";
            }
            else
            {

                return "Dead";
            }
        }
        
        
        
        public Form6()
        {
            InitializeComponent();
            Score1.Text = Dead(MainGame.score[0]);
            if (Score1.Text == "Dead")
            {
                Score1.ForeColor = System.Drawing.Color.Red;
            }
            Score2.Text = Dead(MainGame.score[1]);
            if (Score2.Text == "Dead")
            {
                Score2.ForeColor = System.Drawing.Color.Red;
            }
            Score3.Text = Dead(MainGame.score[2]);
            if (Score3.Text == "Dead")
            {
                Score3.ForeColor = System.Drawing.Color.Red;
            }
            Score4.Text = Dead(MainGame.score[3]);
            if (Score4.Text == "Dead")
            {
                Score4.ForeColor = System.Drawing.Color.Red;
            }
            Score5.Text = Dead(MainGame.score[4]);
            if (Score5.Text == "Dead")
            {
                Score5.ForeColor = System.Drawing.Color.Red;
            }
        }
        
        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
