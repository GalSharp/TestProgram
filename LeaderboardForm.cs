using System;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm()
        {
            InitializeComponent();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("participants.txt");
            Leaderboard leaderboard = new Leaderboard(reader);
            leaderboard.OutputLeaderBoard(leaderBoardLB);
        }
        private void LeaderboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
