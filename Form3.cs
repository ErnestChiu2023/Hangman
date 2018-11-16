using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace prjHangMan
{

    public partial class Form3 : Form
    {
       
        public static int currentPlayer;
        /********************************************************************************
          * *
          * *Below is an example of a function with a return value and one paramter
          * *
          * */
        Boolean alive(int player)//function to check a player's points
        {
            if (MainGame.score[player] < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }/********************************************************************************
          * *
          * *Below is an example of a function without parameters and with no retrurn type
          * *
          * */
        void playerSetup(int player, int current)//assigns the selected player to adjust the points
        {
            MainGame.player = player;
            currentPlayer = current;
        }
        int count = 0;
        public Form3()
        {
            InitializeComponent();
            label3.Text = MainGame.count + " bombs";
            label4.Text = MainGame.died + " bombs";
            btnStart.Enabled = false;
            btn1.Enabled = alive(0);
            if (btn1.Enabled==false)
            {
                btn1.ForeColor = System.Drawing.Color.Red;
            }
            btn2.Enabled = alive(1);
            if (btn2.Enabled == false)
            {
                btn2.ForeColor = System.Drawing.Color.Red;
            }
            btn3.Enabled = alive(2); 
            if (btn3.Enabled == false)
            {
                btn3.ForeColor = System.Drawing.Color.Red;
            }
            btn4.Enabled = alive(3); 
            if (btn4.Enabled == false)
            {
                btn4.ForeColor = System.Drawing.Color.Red;
            }
            btn5.Enabled = alive(4);
            if (btn5.Enabled == false)
            {
                btn5.ForeColor = System.Drawing.Color.Red;
            }
            
        }
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            NewGame frm = new NewGame();
            frm.Show();
            this.Visible = false;

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            playerSetup(0, 1);
            btnStart.Enabled = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            playerSetup(1, 2); 
            btnStart.Enabled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            playerSetup(2, 3);
            btnStart.Enabled = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            playerSetup(3, 4);
            btnStart.Enabled = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            playerSetup(4, 5);
            btnStart.Enabled = true;
        } 
    }
}
