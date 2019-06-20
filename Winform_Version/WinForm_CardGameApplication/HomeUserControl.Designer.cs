namespace WinForm_CardGameApplication
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.PlayerName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sumbit_Name = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Player_Welcome = new System.Windows.Forms.Label();
            this.Card_Counter = new System.Windows.Forms.Label();
            this.Card_Player = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Picture_CardLeft = new System.Windows.Forms.PictureBox();
            this.Picture_CardRight = new System.Windows.Forms.PictureBox();
            this.Cards_Of_Player = new System.Windows.Forms.Label();
            this.Cards_Of_Computer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player_Name = new System.Windows.Forms.Label();
            this.Computer_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Player_Score_Counter = new System.Windows.Forms.Label();
            this.Computer_Score_Counter = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_CardLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_CardRight)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerName_TextBox
            // 
            this.PlayerName_TextBox.Location = new System.Drawing.Point(34, 56);
            this.PlayerName_TextBox.Name = "PlayerName_TextBox";
            this.PlayerName_TextBox.Size = new System.Drawing.Size(253, 20);
            this.PlayerName_TextBox.TabIndex = 1;
            this.PlayerName_TextBox.Text = "Playername";
            this.PlayerName_TextBox.Enter += new System.EventHandler(this.Name_Enter);
            this.PlayerName_TextBox.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Std Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player name:";
            // 
            // Sumbit_Name
            // 
            this.Sumbit_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Sumbit_Name.FlatAppearance.BorderSize = 0;
            this.Sumbit_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sumbit_Name.ForeColor = System.Drawing.Color.White;
            this.Sumbit_Name.Location = new System.Drawing.Point(34, 92);
            this.Sumbit_Name.Name = "Sumbit_Name";
            this.Sumbit_Name.Size = new System.Drawing.Size(98, 23);
            this.Sumbit_Name.TabIndex = 3;
            this.Sumbit_Name.Text = "Submit";
            this.Sumbit_Name.UseVisualStyleBackColor = false;
            this.Sumbit_Name.Click += new System.EventHandler(this.Sumbit_Name_Click);
            // 
            // Player_Welcome
            // 
            this.Player_Welcome.AutoSize = true;
            this.Player_Welcome.Location = new System.Drawing.Point(409, 56);
            this.Player_Welcome.Name = "Player_Welcome";
            this.Player_Welcome.Size = new System.Drawing.Size(58, 13);
            this.Player_Welcome.TabIndex = 4;
            this.Player_Welcome.Text = "Welcome: ";
            // 
            // Card_Counter
            // 
            this.Card_Counter.AutoSize = true;
            this.Card_Counter.Location = new System.Drawing.Point(409, 81);
            this.Card_Counter.Name = "Card_Counter";
            this.Card_Counter.Size = new System.Drawing.Size(75, 13);
            this.Card_Counter.TabIndex = 5;
            this.Card_Counter.Text = "Card amountl: ";
            // 
            // Card_Player
            // 
            this.Card_Player.Location = new System.Drawing.Point(412, 97);
            this.Card_Player.Name = "Card_Player";
            this.Card_Player.Size = new System.Drawing.Size(120, 23);
            this.Card_Player.TabIndex = 6;
            this.Card_Player.Text = "Play next round";
            this.Card_Player.UseVisualStyleBackColor = true;
            this.Card_Player.Click += new System.EventHandler(this.Card_Player_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(579, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 11);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Picture_CardLeft
            // 
            this.Picture_CardLeft.Image = ((System.Drawing.Image)(resources.GetObject("Picture_CardLeft.Image")));
            this.Picture_CardLeft.Location = new System.Drawing.Point(276, 162);
            this.Picture_CardLeft.Name = "Picture_CardLeft";
            this.Picture_CardLeft.Size = new System.Drawing.Size(165, 250);
            this.Picture_CardLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_CardLeft.TabIndex = 8;
            this.Picture_CardLeft.TabStop = false;
            // 
            // Picture_CardRight
            // 
            this.Picture_CardRight.Image = ((System.Drawing.Image)(resources.GetObject("Picture_CardRight.Image")));
            this.Picture_CardRight.Location = new System.Drawing.Point(505, 162);
            this.Picture_CardRight.Name = "Picture_CardRight";
            this.Picture_CardRight.Size = new System.Drawing.Size(165, 250);
            this.Picture_CardRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_CardRight.TabIndex = 9;
            this.Picture_CardRight.TabStop = false;
            // 
            // Cards_Of_Player
            // 
            this.Cards_Of_Player.AutoSize = true;
            this.Cards_Of_Player.Location = new System.Drawing.Point(317, 427);
            this.Cards_Of_Player.Name = "Cards_Of_Player";
            this.Cards_Of_Player.Size = new System.Drawing.Size(73, 13);
            this.Cards_Of_Player.TabIndex = 10;
            this.Cards_Of_Player.Text = "Players\'s Card";
            // 
            // Cards_Of_Computer
            // 
            this.Cards_Of_Computer.AutoSize = true;
            this.Cards_Of_Computer.Location = new System.Drawing.Point(551, 427);
            this.Cards_Of_Computer.Name = "Cards_Of_Computer";
            this.Cards_Of_Computer.Size = new System.Drawing.Size(84, 13);
            this.Cards_Of_Computer.TabIndex = 11;
            this.Cards_Of_Computer.Text = "Computer\'s Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.label2.Font = new System.Drawing.Font("Futura Std Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "ScoreBoard:";
            // 
            // Player_Name
            // 
            this.Player_Name.AutoSize = true;
            this.Player_Name.Location = new System.Drawing.Point(29, 201);
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.Size = new System.Drawing.Size(64, 13);
            this.Player_Name.TabIndex = 13;
            this.Player_Name.Text = "PlayerName";
            // 
            // Computer_Name
            // 
            this.Computer_Name.AutoSize = true;
            this.Computer_Name.Location = new System.Drawing.Point(30, 218);
            this.Computer_Name.Name = "Computer_Name";
            this.Computer_Name.Size = new System.Drawing.Size(86, 13);
            this.Computer_Name.TabIndex = 14;
            this.Computer_Name.Text = "Computer_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Points";
            // 
            // Player_Score_Counter
            // 
            this.Player_Score_Counter.AutoSize = true;
            this.Player_Score_Counter.Location = new System.Drawing.Point(155, 203);
            this.Player_Score_Counter.Name = "Player_Score_Counter";
            this.Player_Score_Counter.Size = new System.Drawing.Size(13, 13);
            this.Player_Score_Counter.TabIndex = 17;
            this.Player_Score_Counter.Text = "0";
            // 
            // Computer_Score_Counter
            // 
            this.Computer_Score_Counter.AutoSize = true;
            this.Computer_Score_Counter.Location = new System.Drawing.Point(155, 218);
            this.Computer_Score_Counter.Name = "Computer_Score_Counter";
            this.Computer_Score_Counter.Size = new System.Drawing.Size(13, 13);
            this.Computer_Score_Counter.TabIndex = 18;
            this.Computer_Score_Counter.Text = "0";
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.reset_button.FlatAppearance.BorderSize = 0;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(21, 444);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 19;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.Computer_Score_Counter);
            this.Controls.Add(this.Player_Score_Counter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Computer_Name);
            this.Controls.Add(this.Player_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cards_Of_Computer);
            this.Controls.Add(this.Cards_Of_Player);
            this.Controls.Add(this.Picture_CardRight);
            this.Controls.Add(this.Picture_CardLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Card_Player);
            this.Controls.Add(this.Card_Counter);
            this.Controls.Add(this.Player_Welcome);
            this.Controls.Add(this.Sumbit_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerName_TextBox);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(720, 485);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_CardLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_CardRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sumbit_Name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Player_Welcome;
        private System.Windows.Forms.Label Card_Counter;
        private System.Windows.Forms.Button Card_Player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Picture_CardLeft;
        private System.Windows.Forms.PictureBox Picture_CardRight;
        private System.Windows.Forms.Label Cards_Of_Player;
        private System.Windows.Forms.Label Cards_Of_Computer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player_Name;
        private System.Windows.Forms.Label Computer_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Player_Score_Counter;
        private System.Windows.Forms.Label Computer_Score_Counter;
        private System.Windows.Forms.Button reset_button;
    }
}
