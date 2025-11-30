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
        private readonly List<string> answers = new()
        {
            // Affirmative answers
            "Verily, it shall come to pass.",
            "By the king's honor, aye indeed.",
            "The stars decree it so.",
            "A most certain truth, fair one.",
            "Yea, destiny smiles upon thee.",
            "So it is written in the old scrolls.",
            "By sword and spell, it shall be done.",
            "The omens bode well for thy wish.",
            // Uncertain answers
            "Ask again when the moon is full.",
            "The fates whisper, yet their words are unclear.",
            "In time, the truth shall reveal itself.",
            "Even the wisest sage cannot foretell this.",
            "The runes speak in riddles this night.",
            "Perchance, though shadows yet linger.",
            // Negative answers
            "Nay, such fortune is not thine.",
            "By the gods, it shall not be.",
            "The stars turn cold against thee.",
            "Abandon hope, for it is not destined.",
            "The answer lieth dark and grim",
            "Thy wish falleth upon deaf heavens",
            "Fate refuseth thy plea."
        };
        public TheEyeofDestiny()
        {
            InitializeComponent();
            SetQuestionPlaceholder();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (IsQuestionMissing())
            {
                answerLabel.Text = "O Seeker, offer a worthy question that honors destiny's tale.";
                return;
            }

            int index = random.Next(answers.Count);
            answerLabel.Text = answers[index];
        }

        private bool IsQuestionMissing()
        {
            if (string.IsNullOrWhiteSpace(questionBox.Text))
            {
                return true;
            }

            return questionBox.Text.Equals(QuestionPlaceholder, StringComparison.OrdinalIgnoreCase);
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

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetQuestionPlaceholder();
            answerLabel.Text = string.Empty;
        }

        private void SetQuestionPlaceholder()
        {
            questionBox.ForeColor = Color.MediumPurple;
            questionBox.Text = QuestionPlaceholder;
        }
    }
}
