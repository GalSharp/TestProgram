using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    public class Leaderboard
    {
        private List<Participant> participants;
        public Leaderboard(StreamReader reader)
        {
            participants = new List<Participant>();
            GetParticipantsList(reader);
        }
        private void GetParticipantsList(StreamReader reader)
        {
            while (!reader.EndOfStream)
            {
                try
                {
                    Participant participant = new Participant(reader.ReadLine(),
                    reader.ReadLine(),
                    reader.ReadLine(),
                    double.Parse(reader.ReadLine()));

                    participants.Add(participant);
                }
                catch { break; }
            }
            reader.Close();
            SortLeaderBoard();
        }
        private void SortLeaderBoard()
        {
            for (int i = 0; i < participants.Count; i++)
            {
                for (int j = 0; j < participants.Count - 1 - i; j++)
                {
                    if (participants[j].mark < participants[j + 1].mark)
                    {
                        (participants[j], participants[j + 1]) = (participants[j + 1], participants[j]);
                    }
                }
            }
        }
        public void OutputLeaderBoard(ListBox liderBoard)
        {
            int i = 1;
            liderBoard.Items.Add($"№\tИМЯ\t\tФАМИЛИЯ\tГруппа\tОЦЕНКА");
            foreach (var participant in participants)
            {
                //проверка длины имени и фамилии
                string spaceFirstName = participant.firstName.Length >= 9 ? $"\t" : "\t\t";
                string spaceLastName = participant.lastName.Length >= 9 ? $"\t" : "\t\t";

                liderBoard.Items.Add($"№{i}\t{participant.firstName}{spaceFirstName}" +
                    $"{participant.lastName}{spaceLastName}" +
                    $"{participant.group}" +
                    $"\t{participant.mark}");
                i++;
            }
        }
    }
}
