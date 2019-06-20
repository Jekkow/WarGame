using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CardGameApplication
{
    public partial class HomeUserControl : UserControl
    {
        DAL DataAccessLayer = new DAL();

        public HomeUserControl()
        {
            //Hide All
            InitializeComponent();
            Card_Player.Hide();
            Card_Counter.Hide();
            Player_Welcome.Hide();
            Picture_CardLeft.Hide();
            Picture_CardRight.Hide();
            Cards_Of_Computer.Hide();
            Cards_Of_Player.Hide();
            label2.Hide();
            Player_Name.Hide();
            Computer_Name.Hide();
            Player_Score_Counter.Hide();
            Computer_Score_Counter.Hide();
            label3.Hide();
            label4.Hide();
            reset_button.Hide();
        }

        private void Sumbit_Name_Click(object sender, EventArgs e)
        {
            //Popup |   No playername is given
            if (PlayerName_TextBox.Text == "")
            {
                PlayerName_TextBox.Text = "";
                System.Windows.Forms.MessageBox.Show("Invalid Playername\nPlayername may not be empty");

            }
            //Popup |   Playername starts with "SPACE"
            else if (PlayerName_TextBox.Text.StartsWith(" "))
            {
                PlayerName_TextBox.Text = "";
                System.Windows.Forms.MessageBox.Show("Invalid Playername\nPlayername may not start with [SPACE]");
            }
            else
            {
                DataAccessLayer.CreateGame(PlayerName_TextBox.Text);

                string context = PlayerName_TextBox.Text;
                Player_Welcome.Show();
                Player_Welcome.Text = "Welcome: " + context;
                Player_Name.Text = context;
                Computer_Name.Text = Convert.ToString(DataAccessLayer.PlayerList[1].Get_PlayerName());

                //Show All
                Card_Player.Show();
                Card_Counter.Show();
                Picture_CardLeft.Show();
                Picture_CardRight.Show();
                Cards_Of_Player.Show();
                Cards_Of_Computer.Show();
                label2.Show();
                Player_Name.Show();
                Computer_Name.Show();
                Player_Score_Counter.Show();
                Computer_Score_Counter.Show();
                label3.Show();
                label4.Show();
                reset_button.Show();

                Card_Counter.Text = "Card amount: " + DataAccessLayer.PlayerList[0].PlayerHand.Count;

            }          
        }

        private void Card_Player_Click(object sender, EventArgs e)
        {
            if (PlayerName_TextBox.Text == "" || PlayerName_TextBox.Text.StartsWith(" "))
            {
                PlayerName_TextBox.Text = "";
                System.Windows.Forms.MessageBox.Show("No Username is set");

            }
            //Popup |   Who won the game
            else if (DataAccessLayer.PlayerList[0].PlayerHand.Count == 0)
            {
                if (DataAccessLayer.PlayerList[0].Get_PlayerScore() > DataAccessLayer.PlayerList[1].Get_PlayerScore())
                {
                    MessageBox.Show(DataAccessLayer.PlayerList[0].Get_PlayerName() + "\n Is the winner with " + DataAccessLayer.PlayerList[0].Get_PlayerScore() + " Points");
                }
                else if (DataAccessLayer.PlayerList[0].Get_PlayerScore() == DataAccessLayer.PlayerList[1].Get_PlayerScore())
                {
                    MessageBox.Show("Its a draw with " + DataAccessLayer.PlayerList[0].Get_PlayerScore() + " Points");
                }
                else
                {
                    MessageBox.Show(DataAccessLayer.PlayerList[1].Get_PlayerName() + "\n Is the winner with " + DataAccessLayer.PlayerList[1].Get_PlayerScore() + " Points");
                }
            }
            else
            {
                //The Game
                Picture_CardLeft.Load(DataAccessLayer.PlayerList[0].PlayerHand[0].Get_CardFileName());
                Picture_CardRight.Load(DataAccessLayer.PlayerList[1].PlayerHand[0].Get_CardFileName());
                DataAccessLayer.PlayGame();
                Card_Counter.Text = "Card amount: " + DataAccessLayer.PlayerList[0].PlayerHand.Count;
                Player_Score_Counter.Text = Convert.ToString(DataAccessLayer.PlayerList[0].Get_PlayerScore());
                Computer_Score_Counter.Text = Convert.ToString(DataAccessLayer.PlayerList[1].Get_PlayerScore());
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void Name_Enter(object sender, EventArgs e)
        {
            if (PlayerName_TextBox.Text == "Playername")
            {
                PlayerName_TextBox.Text = "";
            }
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (PlayerName_TextBox.Text == "")
            {
                PlayerName_TextBox.Text = "Playername";
            }
        }
    }
}
