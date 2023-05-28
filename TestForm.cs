using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        public string firstName;
        public string lastName;
        public string group;
        double mark;
        double questionCount;
        double rightAnswers;
        int radioButtonIndex;
        RadioButton[] answers;
        StreamReader reader;
        private void TestForm_Load(object sender, EventArgs e)
        {
            answers = new RadioButton[4]
            {
                firstAnswerRB,
                secondAnswerRB,
                thirdAnswerRB,
                fourthAnswerRB
            };
            foreach (RadioButton rb in answers)
            {
                rb.CheckedChanged += OnRadioButtonChecked;
            }
            StartTest();
        }
        private void OnRadioButtonChecked(object sender, EventArgs e)
        {
            nextMotionBtn.Enabled = true;
            RadioButton radioButton = (RadioButton)sender;
            radioButtonIndex = int.Parse(radioButton.Tag.ToString());
        }
        private void StartTest()
        {
            reader = new StreamReader(Directory.GetCurrentDirectory() + @"\Tests\test.txt", Encoding.UTF8);
            themeL.Text = $"Тема теста : {reader.ReadLine()}";
            NextQuestion();
        }
        private void NextQuestion()
        {
            questionTB.Text = reader.ReadLine();
            foreach (RadioButton rb in answers)
            {
                rb.Checked = false;
                rb.Text = reader.ReadLine();
            }
            questionCount++;
            nextMotionBtn.Enabled = false;
            if (reader.EndOfStream)
            {
                nextMotionBtn.Text = "Завершить";
                nextMotionBtn.Enabled = true;
                questionCount--;
                reader.Close();
            }
        }
        private void nextMotionBtn_Click(object sender, EventArgs e)
        {
            switch (nextMotionBtn.Text)
            {
                case "Следующий вопрос":
                    if (radioButtonIndex == int.Parse(reader.ReadLine())) rightAnswers++;
                    NextQuestion();
                    break;
                case "Завершить":
                    TestEnd();
                    break;
                case "Начать тест сначала":
                    StartTest();
                    break;
            }
        }
        private void TestEnd()
        {
            mark = Math.Round(rightAnswers / questionCount * 5, 2);
            var result = MessageBox.Show($"Поздравляю, вы прошли тест - ваш результат : {rightAnswers} из {questionCount}" +
                $"\nВаша оценка {mark}" +
                $"\nХотите чтобы мы занесли вас в список прошедших?", "Конец теста", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string[] participants = File.ReadAllLines("participants.txt");
                bool retry = false;
                for (int i = 0; i < participants.Length; i += 4)
                {
                    if (firstName == participants[i] && lastName == participants[i + 1] && group == participants[i + 2])
                    {
                        if (mark > double.Parse(participants[i + 3]))
                        {
                            participants[i + 3].Replace(participants[i + 3], $"{mark}");
                            retry = true;
                        }
                        break;
                    }
                }
                if (retry)
                {
                    StreamWriter writer = new StreamWriter("participants.txt");
                    foreach (string data in participants)
                    {
                        writer.WriteLine(data);
                    }
                    writer.Close();
                }
                else
                {
                    File.AppendAllText("participants.txt", $"{firstName}\n{lastName}\n{group}\n{mark}\n");
                }
            }
            nextMotionBtn.Text = "Начать тест сначала";
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
