namespace WinForm_CardGameApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Home = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_Rules = new System.Windows.Forms.Button();
            this.button_Options = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeUserControl1 = new WinForm_CardGameApplication.HomeUserControl();
            this.rulesUserControl1 = new WinForm_CardGameApplication.RulesUserControl();
            this.optionsUserControl1 = new WinForm_CardGameApplication.OptionsUserControl();
            this.exitUserControl1 = new WinForm_CardGameApplication.ExitUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button_Home
            // 
            this.button_Home.FlatAppearance.BorderSize = 0;
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Futura Std Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.Location = new System.Drawing.Point(0, 195);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(275, 85);
            this.button_Home.TabIndex = 2;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel_Menu.Location = new System.Drawing.Point(0, 195);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(5, 85);
            this.panel_Menu.TabIndex = 3;
            // 
            // button_Rules
            // 
            this.button_Rules.FlatAppearance.BorderSize = 0;
            this.button_Rules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rules.Font = new System.Drawing.Font("Futura Std Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Rules.Location = new System.Drawing.Point(0, 280);
            this.button_Rules.Name = "button_Rules";
            this.button_Rules.Size = new System.Drawing.Size(275, 85);
            this.button_Rules.TabIndex = 4;
            this.button_Rules.Text = "Rules";
            this.button_Rules.UseVisualStyleBackColor = true;
            this.button_Rules.Click += new System.EventHandler(this.button_Rules_Click);
            // 
            // button_Options
            // 
            this.button_Options.FlatAppearance.BorderSize = 0;
            this.button_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Options.Font = new System.Drawing.Font("Futura Std Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Options.Location = new System.Drawing.Point(0, 365);
            this.button_Options.Name = "button_Options";
            this.button_Options.Size = new System.Drawing.Size(275, 85);
            this.button_Options.TabIndex = 5;
            this.button_Options.Text = "Options";
            this.button_Options.UseVisualStyleBackColor = true;
            this.button_Options.Click += new System.EventHandler(this.button_Options_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Futura Std Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Exit.Location = new System.Drawing.Point(0, 450);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(275, 85);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.homeUserControl1);
            this.panel2.Controls.Add(this.rulesUserControl1);
            this.panel2.Controls.Add(this.optionsUserControl1);
            this.panel2.Controls.Add(this.exitUserControl1);
            this.panel2.Location = new System.Drawing.Point(275, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 485);
            this.panel2.TabIndex = 9;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Home";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Gadugi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(885, 199);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(602, 129);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Home";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(720, 485);
            this.homeUserControl1.TabIndex = 3;
            this.homeUserControl1.Load += new System.EventHandler(this.homeUserControl1_Load);
            // 
            // rulesUserControl1
            // 
            this.rulesUserControl1.Location = new System.Drawing.Point(0, 0);
            this.rulesUserControl1.Name = "rulesUserControl1";
            this.rulesUserControl1.Size = new System.Drawing.Size(720, 485);
            this.rulesUserControl1.TabIndex = 2;
            // 
            // optionsUserControl1
            // 
            this.optionsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.optionsUserControl1.Name = "optionsUserControl1";
            this.optionsUserControl1.Size = new System.Drawing.Size(720, 485);
            this.optionsUserControl1.TabIndex = 1;
            // 
            // exitUserControl1
            // 
            this.exitUserControl1.Location = new System.Drawing.Point(0, 0);
            this.exitUserControl1.Name = "exitUserControl1";
            this.exitUserControl1.Size = new System.Drawing.Size(720, 485);
            this.exitUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Options);
            this.Controls.Add(this.button_Rules);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Options;
        private System.Windows.Forms.Button button_Rules;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private HomeUserControl homeUserControl1;
        private RulesUserControl rulesUserControl1;
        private OptionsUserControl optionsUserControl1;
        private ExitUserControl exitUserControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

