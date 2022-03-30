using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamShuffle
{
    public partial class Form1 : Form
    {
        //message in warning if number of players is not even
        string message = "Player count must be even.";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void shuffle_button_Click(object sender, EventArgs e)
        {
            //Add all players to list
            //*Reflection can be used to do it in loop
            List<string> players = new List<string>();
            players.Add(team1_player1.Text);
            players.Add(team1_player2.Text);
            players.Add(team1_player3.Text);
            players.Add(team1_player4.Text);
            players.Add(team1_player5.Text);
            players.Add(team2_player1.Text);
            players.Add(team2_player2.Text);
            players.Add(team2_player3.Text);
            players.Add(team2_player4.Text);
            players.Add(team2_player5.Text);

            //remove all empty strings
            for (int i = 0; i < players.Count; i++)
            {
                if (!Functions.CheckIfIsEmpty(players[i]))
                {
                    players.RemoveAt(i);
                    i--;
                }
            }
            //if teams are not equal, send message
            if (players.Count % 2 != 0)
            {
                MessageBox.Show(message,"Warning");
            }
            else
            {
                //Set all players to their positions
                players = Functions.ShufflePlayers(players);
                team1_player1.Text = players[0];
                team1_player2.Text = players[1];
                team1_player3.Text = players[2];
                team1_player4.Text = players[3];
                team1_player5.Text = players[4];
                team2_player1.Text = players[5];
                team2_player2.Text = players[6];
                team2_player3.Text = players[7];
                team2_player4.Text = players[8];
                team2_player5.Text = players[9];
            }
        }

        //load players from txt file
        private void load_button_Click(object sender, EventArgs e)
        {
            if(loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = loadFileDialog.FileName;
                string readFile = File.ReadAllText(fileName);
                string[] players = readFile.Split('\n');
                team1_player1.Text = players[0];
                team1_player2.Text = players[1];
                team1_player3.Text = players[2];
                team1_player4.Text = players[3];
                team1_player5.Text = players[4];
                team2_player1.Text = players[5];
                team2_player2.Text = players[6];
                team2_player3.Text = players[7];
                team2_player4.Text = players[8];
                team2_player5.Text = players[9];
            }
        }

        //save players to txt file
        private void save_button_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                string players = "";
                players += team1_player1.Text + '\n';
                players += team1_player2.Text + '\n';
                players += team1_player3.Text + '\n';
                players += team1_player4.Text + '\n';
                players += team1_player5.Text + '\n';
                players += team2_player1.Text + '\n';
                players += team2_player2.Text + '\n';
                players += team2_player3.Text + '\n';
                players += team2_player4.Text + '\n';
                players += team2_player5.Text;
                File.WriteAllText(path, players);
            }
        }
    }
}
