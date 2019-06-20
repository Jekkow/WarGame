using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CardGameApplication
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            panel_Menu.Location = button_Home.Location;
            homeUserControl1.BringToFront();
        }

        private void button_Rules_Click(object sender, EventArgs e)
        {
            panel_Menu.Location = button_Rules.Location;
            rulesUserControl1.BringToFront();
        }

        private void button_Options_Click(object sender, EventArgs e)
        {
            panel_Menu.Location = button_Options.Location;
            optionsUserControl1.BringToFront();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            panel_Menu.Location = button_Exit.Location;
            exitUserControl1.BringToFront();
        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
