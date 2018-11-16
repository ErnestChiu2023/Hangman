namespace prjHangMan
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rtbWord = new System.Windows.Forms.RichTextBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.rtbguessLetter = new System.Windows.Forms.RichTextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnguessLetter = new System.Windows.Forms.Button();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lblwrongLetters = new System.Windows.Forms.Label();
            this.rtbguessWord = new System.Windows.Forms.RichTextBox();
            this.lblguessWord = new System.Windows.Forms.Label();
            this.btnguessWord = new System.Windows.Forms.Button();
            this.pbLaptop = new System.Windows.Forms.PictureBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblPhoneBackground = new System.Windows.Forms.Label();
            this.lblCall = new System.Windows.Forms.Label();
            this.btnCall = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblFullhint = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(605, 87);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quick! Defuse The Bomb!";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Black;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(719, 365);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(121, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // rtbWord
            // 
            this.rtbWord.BackColor = System.Drawing.Color.Black;
            this.rtbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbWord.Location = new System.Drawing.Point(681, 406);
            this.rtbWord.Name = "rtbWord";
            this.rtbWord.Size = new System.Drawing.Size(205, 104);
            this.rtbWord.TabIndex = 3;
            this.rtbWord.Text = "";
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.Brown;
            this.btnBegin.Location = new System.Drawing.Point(724, 432);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(126, 50);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Begin!";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // rtbguessLetter
            // 
            this.rtbguessLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbguessLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbguessLetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbguessLetter.Location = new System.Drawing.Point(71, 296);
            this.rtbguessLetter.MaxLength = 1;
            this.rtbguessLetter.Name = "rtbguessLetter";
            this.rtbguessLetter.Size = new System.Drawing.Size(323, 49);
            this.rtbguessLetter.TabIndex = 5;
            this.rtbguessLetter.Text = "";
            this.rtbguessLetter.WordWrap = false;
            this.rtbguessLetter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbguessLetter_KeyDown);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.BackColor = System.Drawing.Color.Black;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGuess.Location = new System.Drawing.Point(77, 252);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(168, 29);
            this.lblGuess.TabIndex = 6;
            this.lblGuess.Text = "Guess Letter:";
            // 
            // btnguessLetter
            // 
            this.btnguessLetter.BackColor = System.Drawing.Color.Gray;
            this.btnguessLetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnguessLetter.Location = new System.Drawing.Point(251, 252);
            this.btnguessLetter.Name = "btnguessLetter";
            this.btnguessLetter.Size = new System.Drawing.Size(145, 39);
            this.btnguessLetter.TabIndex = 7;
            this.btnguessLetter.Text = "Guess Letter!";
            this.btnguessLetter.UseVisualStyleBackColor = false;
            this.btnguessLetter.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetters.Location = new System.Drawing.Point(960, 30);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(191, 25);
            this.lblLetters.TabIndex = 8;
            this.lblLetters.Text = "Incorrect Letters:";
            // 
            // lblwrongLetters
            // 
            this.lblwrongLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblwrongLetters.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwrongLetters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblwrongLetters.Location = new System.Drawing.Point(884, 72);
            this.lblwrongLetters.Name = "lblwrongLetters";
            this.lblwrongLetters.Size = new System.Drawing.Size(318, 57);
            this.lblwrongLetters.TabIndex = 9;
            // 
            // rtbguessWord
            // 
            this.rtbguessWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbguessWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbguessWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbguessWord.Location = new System.Drawing.Point(71, 461);
            this.rtbguessWord.Name = "rtbguessWord";
            this.rtbguessWord.Size = new System.Drawing.Size(323, 49);
            this.rtbguessWord.TabIndex = 10;
            this.rtbguessWord.Text = "";
            this.rtbguessWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbguessWord_KeyDown);
            // 
            // lblguessWord
            // 
            this.lblguessWord.AutoSize = true;
            this.lblguessWord.BackColor = System.Drawing.Color.Black;
            this.lblguessWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguessWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblguessWord.Location = new System.Drawing.Point(82, 421);
            this.lblguessWord.Name = "lblguessWord";
            this.lblguessWord.Size = new System.Drawing.Size(163, 29);
            this.lblguessWord.TabIndex = 11;
            this.lblguessWord.Text = "Guess Word:";
            // 
            // btnguessWord
            // 
            this.btnguessWord.BackColor = System.Drawing.Color.Gray;
            this.btnguessWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnguessWord.Location = new System.Drawing.Point(249, 416);
            this.btnguessWord.Name = "btnguessWord";
            this.btnguessWord.Size = new System.Drawing.Size(145, 39);
            this.btnguessWord.TabIndex = 12;
            this.btnguessWord.Text = "Guess Word!";
            this.btnguessWord.UseVisualStyleBackColor = false;
            this.btnguessWord.Click += new System.EventHandler(this.btnguessWord_Click);
            // 
            // pbLaptop
            // 
            this.pbLaptop.BackColor = System.Drawing.Color.Transparent;
            this.pbLaptop.Image = ((System.Drawing.Image)(resources.GetObject("pbLaptop.Image")));
            this.pbLaptop.Location = new System.Drawing.Point(23, 58);
            this.pbLaptop.Name = "pbLaptop";
            this.pbLaptop.Size = new System.Drawing.Size(623, 684);
            this.pbLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLaptop.TabIndex = 13;
            this.pbLaptop.TabStop = false;
            // 
            // lblComputer
            // 
            this.lblComputer.BackColor = System.Drawing.Color.Black;
            this.lblComputer.CausesValidation = false;
            this.lblComputer.Location = new System.Drawing.Point(61, 239);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(541, 288);
            this.lblComputer.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Black;
            this.lblTimer.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimer.Location = new System.Drawing.Point(694, 239);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(177, 106);
            this.lblTimer.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(786, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(538, 288);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(23, 86);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 59);
            this.lblMessage.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(957, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 408);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // lblPhoneBackground
            // 
            this.lblPhoneBackground.AllowDrop = true;
            this.lblPhoneBackground.BackColor = System.Drawing.Color.Black;
            this.lblPhoneBackground.Location = new System.Drawing.Point(965, 200);
            this.lblPhoneBackground.Name = "lblPhoneBackground";
            this.lblPhoneBackground.Size = new System.Drawing.Size(177, 327);
            this.lblPhoneBackground.TabIndex = 20;
            // 
            // lblCall
            // 
            this.lblCall.AutoSize = true;
            this.lblCall.BackColor = System.Drawing.Color.Black;
            this.lblCall.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCall.Location = new System.Drawing.Point(988, 213);
            this.lblCall.Name = "lblCall";
            this.lblCall.Size = new System.Drawing.Size(126, 34);
            this.lblCall.TabIndex = 21;
            this.lblCall.Text = "Call for Help!";
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCall.BackgroundImage")));
            this.btnCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCall.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCall.Location = new System.Drawing.Point(994, 250);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(120, 97);
            this.btnCall.TabIndex = 22;
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.Black;
            this.lblHint.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHint.Location = new System.Drawing.Point(976, 391);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(53, 34);
            this.lblHint.TabIndex = 23;
            this.lblHint.Text = "Hint:";
            // 
            // lblFullhint
            // 
            this.lblFullhint.BackColor = System.Drawing.Color.Black;
            this.lblFullhint.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullhint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFullhint.Location = new System.Drawing.Point(976, 425);
            this.lblFullhint.Name = "lblFullhint";
            this.lblFullhint.Size = new System.Drawing.Size(154, 85);
            this.lblFullhint.TabIndex = 24;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Black;
            this.lblWarning.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWarning.Location = new System.Drawing.Point(976, 357);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(150, 24);
            this.lblWarning.TabIndex = 25;
            this.lblWarning.Text = "Ten seconds will be lost";
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 624);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblFullhint);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.lblCall);
            this.Controls.Add(this.lblPhoneBackground);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnguessWord);
            this.Controls.Add(this.lblguessWord);
            this.Controls.Add(this.rtbguessWord);
            this.Controls.Add(this.lblwrongLetters);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.btnguessLetter);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.rtbguessLetter);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.rtbWord);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbLaptop);
            this.Controls.Add(this.lblComputer);
            this.Name = "MainGame";
            this.Text = "Main Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RichTextBox rtbWord;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.RichTextBox rtbguessLetter;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnguessLetter;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblwrongLetters;
        private System.Windows.Forms.RichTextBox rtbguessWord;
        private System.Windows.Forms.Label lblguessWord;
        private System.Windows.Forms.Button btnguessWord;
        private System.Windows.Forms.PictureBox pbLaptop;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblPhoneBackground;
        private System.Windows.Forms.Label lblCall;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblFullhint;
        private System.Windows.Forms.Label lblWarning;
    }
}

