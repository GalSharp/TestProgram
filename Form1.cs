using System;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void startTestBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTB.Text == "" || lastNameTB.Text == "" || groupCB.SelectedItem == null)
            {
                invalideInputL.Visible = true;
            }
            else
            {
                TestForm start = new TestForm();
                HandOverParticipant(start);
                GoingToForm(start);
            }
        }
        private void GoingToForm(object testForm)
        {
            Form form = (Form)testForm;
            form.Show();
            this.Hide();
        }
        private void HandOverParticipant(TestForm testForm)
        {
            testForm.firstName = firstNameTB.Text;
            testForm.lastName = lastNameTB.Text;
            testForm.group = groupCB.SelectedItem.ToString();
        }
        private void leaderBoardBtn_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboard = new LeaderboardForm();
            GoingToForm(leaderboard);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
