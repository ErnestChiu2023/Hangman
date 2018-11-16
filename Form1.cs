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
    public partial class MainGame : Form
    {
        //Variables 
        public static int count = 0;//counts how many times the player defused the bomb
        public static int died = 0;//counts how many times the player died
        //the following are our catagory words
        /********************************************************************************
          * *
          * *Below is an example of arrays
          * *
          * */
        public static string[] animals = { "mole", "penguin", "panda", "ape", "harambe", "hippo", "elephant", "turtle", "shark", "ant eater", "rabbit", "sloth", "cat" };
        public static string[] food = {"cabbage","carrot","cake","chips","gaham crackers","hamburger","spaghetti","waffles","kiwi","ice cream","rice","honey"};
        public static string[] countries = {"afghanistan","algeria","belgium","canada","egypt","france","germany","greece","iceland","italy","korea","japan","mexico"};
        public static string[] games = { "league of legends","pokemon","starcraft","overwatch","csgo","titanfall","call of duty","portal","hearthstone"};
        public static string[] artists = {"drake","rihanna","beyonce","madonna","kanye west","adele","taylor swift","eminem","the weeknd","justin bieber","nicki minaj","ariana grande"};
        public static string[] subjects = {"physics","chemistry","biology","history","music","art","geography","physical education","math","english","woodshop","band"};
        public static string[] mainArray;//this is a varaible that contains the current selected array
        public static int[] score ={0,0,0,0,0};//stores current player scores
        public static string catagory;//tells the player what catagory is currently selectted
        Random r = new Random();//random variable
        public static string word;//stores the current word
        string hiddenWord;//the word that is displayed to the player
        WindowsMediaPlayer countDown = new WindowsMediaPlayer();//Count down sound
        WindowsMediaPlayer soundEffects = new WindowsMediaPlayer();
        WindowsMediaPlayer background = new WindowsMediaPlayer();
        int time;//counts the amount of time that the player has
        public static int player;//the current player
        /********************************************************************************
          * *
          * *Below is an example of a function with one paramater and no functions
          * *
          * */
        void visibility(Boolean visibility)//function used to turn off all objects before they hit start
        {
            lblGuess.Visible = visibility;
            lblguessWord.Visible = visibility;
            lblLetters.Visible = visibility;
            lblPassword.Visible = visibility;
            lblTitle.Visible = visibility;
            lblwrongLetters.Visible = visibility;
            rtbguessLetter.Visible = visibility;
            rtbguessWord.Visible = visibility;
            rtbWord.Visible = visibility;
            btnguessLetter.Visible = visibility;
            btnguessWord.Visible = visibility;
            pictureBox1.Visible = visibility;
            pictureBox2.Visible = visibility;
            lblFullhint.Visible = visibility;
            lblWarning.Visible = visibility;
            lblHint.Visible = visibility;
            lblPhoneBackground.Visible = visibility;
            
        }
        public MainGame()
        {
            InitializeComponent();
            visibility(false);//turns off all of the objects
            timer1.Enabled = false;//turns off the timer
            word = mainArray[r.Next(0, mainArray.Length)];//choose the word randomly from the array
            time = word.Length * 10;//calculates te amount of time that the player has to solve the question
            btnCall.Visible = false;
            lblCall.Visible = false;
            background.URL = "Background.wav";
        }


        private void btnBegin_Click(object sender, EventArgs e)
        {
            btnCall.Visible = true;
            lblCall.Visible = true;
            timer1.Enabled = true;//turns on the timer
            visibility(true);//turns on all of the objects
            btnBegin.Visible = false;//hides the begin button
            lblMessage.Text = "Catagory: " + catagory;//displays the current catagory
            string letter;//used to check what letter the player inputted
            for (int x = 0; x < word.Length; x++)
            {
                letter = word.Substring(x, 1);//adding dashes for the amount of letters there are in the word
                if (letter == " ")
                {
                    hiddenWord += " ";
                }
                else
                {
                   hiddenWord  += "-";
                }
            }
            rtbWord.Enabled = false;//disables the word box, so that the player cannot adjust the word
            btnBegin.Enabled=false;//turns off the begin button
            rtbWord.Text = hiddenWord;//displays the hidden word to the player
            rtbguessLetter.MaxLength = 1;//prevents the player from putting more than one word in the textbox
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
                string guess = rtbguessLetter.Text;//taking the letter from the guess box
                guess = guess.ToLower();
                string check;//stores the word that the player inputted
                int correct = 0;//checks if the player has gotten the word

                for (int x = 0; x < word.Length; x++)
                {
                    check = word.Substring(x, 1);
                    if (guess == check)//checking if the letter is in the word
                    {
                        hiddenWord = hiddenWord.Remove(x, 1);//removing the dash from the word
                        hiddenWord = hiddenWord.Insert(x, guess);//adding the letter to the word
                        correct += 1;
                    }
                    else
                    {
                        if (word.IndexOf(guess) < 0)
                        {
                            if (lblwrongLetters.Text.IndexOf(guess) < 0)
                            {

                                lblwrongLetters.Text += guess + " ";
                                time -= word.Length;
                            }
                        }
                    }
                }
                if (correct > 0)//plays the correct sound
                {

                    timer1.Enabled = false;
                    soundEffects.URL = "Correct.wav";
                    timer1.Enabled = true;
                }
                else//plays the incorrect sound
                {

                    timer1.Enabled = false;
                    soundEffects.URL = "Incorrect.wav";
                    timer1.Enabled = true;

                }
                rtbWord.Text = hiddenWord;//displaying the word
                if (hiddenWord == word)//checks if they have discovered all the words
                {
                    score[player] += time / (lblwrongLetters.Text.Length + 1);
                    soundEffects.URL = "Defused.wav";
                    Form4 frm = new Form4();
                    frm.Show();
                    this.Close();
                }
               
                
           
        }

        private void btnguessWord_Click(object sender, EventArgs e)//checks if the player has gotten the word
        {
            string guess = rtbguessWord.Text;
            guess = guess.Trim();
            guess = guess.ToLower();
            if (guess == word)
            {
                score[player] += time / (lblwrongLetters.Text.Length + 1);
                timer1.Enabled = false;
                soundEffects.URL = "Correct.wav";
                timer1.Enabled = true;
                soundEffects.URL = "Defused.wav";
                Form4 frm = new Form4();//displays the victory screen
                frm.Show();
                this.Close();
            }
            else
            {
                
                timer1.Enabled = false;
                soundEffects.URL = "Incorrect.wav";
                timer1.Enabled = true; 
                time/=2;//they lose half of their time if their guess is incorrect
                btnguessWord.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//counts down from the time
        {
            time--;
            soundEffects.URL = "Sound (2).wav";
            lblTimer.Text = time + "";
            if (time <= 0)
            {
                score[player] = -1;
                soundEffects.URL = "Explode.wav";
                Form5 frm = new Form5();
                frm.Show();
                this.Close();
            }
            if (time == 10)//if there is ten seconds left it will start the 10 seconds countdown
            {
                countDown.URL = "Countdown.mp3";
            }
        }
        private void btnCall_Click(object sender, EventArgs e)
        {
            btnCall.Enabled = false;//make sures the player can only call once
            time -= 10;//subtracts 10 from the timer if they call
            string trimmed = word.Trim();
            lblFullhint.Text="The letter " + trimmed.Substring(r.Next(0, word.Length),1) + " is in the word!";//displays the hint
        }
        private void rtbguessLetter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnGuess_Click((object)sender, (EventArgs)e);
            }
        }

        private void rtbguessWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnguessWord_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
