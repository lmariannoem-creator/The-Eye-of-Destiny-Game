using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Eye_of_Destiny_Game
{
    public partial class TheEyeofDestiny : Form
    {
        Random random = new Random();
        List<string> answers = new List<string>();
        public TheEyeofDestiny()
        {
            InitializeComponent();
            // Yes answers
            answers.Add("Verily, it shall come to pass.");
            answers.Add("By the king's honor, aye indeed.");
            answers.Add("The stars decree it so.");
            answers.Add("A most certain truth, fair one.");
            answers.Add("Yea, destiny smiles upon thee.");
            answers.Add("So it is written in the old scrolls.");
            answers.Add("By sword and spell, it shall be done.");
            answers.Add("The omens bode well for thy wish.");
            // Not sure answers
            answers.Add("Ask again when the moon is full.");
            answers.Add("The fates whisper, yet their words are unclear.");
            answers.Add("In time, the truth shall reveal itself.");
            answers.Add("Even the wisest sage cannot foretell this.");
            answers.Add("The runes speak in riddles this night.");
            answers.Add("Perchance, though shadows yet linger.");
            //Negative answers
            answers.Add("Nay, such fortune is not thine.");
            answers.Add("By the gods, it shall not be.");
            answers.Add("The stars turn cold against thee.");
            answers.Add("Abandon hope, for it is not destined.");
            answers.Add("The answer lieth dark and grim");
            answers.Add("Thy wish falleth upon deaf heavens");
            answers.Add("Fate refuseth thy plea.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int index = random.Next(answers.Count);
            answerLabel.Text = answers[index];
        }

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            questionBox.Text = "";
            answerLabel.Text = "";
        }
    }
}
