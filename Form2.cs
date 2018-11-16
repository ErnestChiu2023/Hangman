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

    public partial class NewGame : Form
    {
        
        public NewGame()
        {
            InitializeComponent();
        }

//************************************************************************************************************************************//
        //The following code are used to select the catagory and close the current form. Furthermore, it opens the main game.
        private void btnAnimals_Click(object sender, EventArgs e)
        {
            MainGame.mainArray = MainGame.animals;
            MainGame.catagory = "animals";
            this.Close();
            MainGame frm = new MainGame();
            frm.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            MainGame.mainArray = MainGame.food;
            MainGame.catagory = "food";
            this.Close();
            MainGame frm = new MainGame();
            frm.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            MainGame.mainArray = MainGame.games;
            MainGame.catagory = "games";
            this.Close();
            MainGame frm = new MainGame();
            frm.Show();
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            MainGame.mainArray = MainGame.artists;
            MainGame.catagory = "artists";
            this.Close();
            MainGame frm = new MainGame();
            frm.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            MainGame.mainArray = MainGame.subjects;
            MainGame.catagory = "subjects";
            this.Close();
            MainGame frm = new MainGame();
            frm.Show();
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            MainGame.mainArray = MainGame.countries;
            MainGame.catagory = "countries";
            this.Close();
            MainGame frm = new MainGame();
            frm.Show();
        }
    }
}
