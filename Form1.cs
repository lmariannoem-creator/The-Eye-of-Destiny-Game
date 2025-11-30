using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EyeOfDestinyNet8
{
    public partial class TheEyeofDestiny : Form
    {
        private const string QuestionPlaceholder = "type your question here...";
        private readonly Random random = new();
        private readonly List<string> answers = new();
        public TheEyeofDestiny()
        {
            InitializeComponent();
            SetQuestionPlaceholder();
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

        private void questionBox_Enter(object sender, EventArgs e)
        {
            if (questionBox.Text == QuestionPlaceholder)
            {
                questionBox.Text = string.Empty;
                questionBox.ForeColor = Color.Purple;
            }
        }

        private void questionBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(questionBox.Text))
            {
                SetQuestionPlaceholder();
            }
        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetQuestionPlaceholder();
            answerLabel.Text = "";
        }

        private void SetQuestionPlaceholder()
        {
            questionBox.ForeColor = Color.MediumPurple;
            questionBox.Text = QuestionPlaceholder;
        }
    }
}
