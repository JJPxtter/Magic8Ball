namespace Magic8Ball
{
    public partial class MagicEightBall : Form
    {

        Random random = new Random();
        List<String> answers = new List<String>();

        public MagicEightBall()
        {
            InitializeComponent();
            answers.Add("It is certain.");
            answers.Add("It is decidedly so.");
            answers.Add("Without a doubt.");
            answers.Add("Yes definitely.");
            answers.Add("You may rely on it.");
            answers.Add("As I see it, yes.");
            answers.Add("Most likely.");
            answers.Add("Outlook good.");
            answers.Add("Yes.");
            answers.Add("Signs point to yes.");
            answers.Add("Reply hazy, try again");
            answers.Add("Ask again later.");
            answers.Add("Better not tell you now.");
            answers.Add("Cannot predict now.");
            answers.Add("Concentrate and ask again.");
            answers.Add("Don't count on it.");
            answers.Add("My reply is no.");
            answers.Add("My sources say no.");
            answers.Add("Outlook not so good.");
            answers.Add("Very doubtful.");


        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(questionBox.Text))
            {
                answerLabel.Text = "";
                MessageBox.Show("Please ask a Question");
                return;
            }
            if (questionBox.Text.Contains("Ask any question here..."))
            {
                answerLabel.Text = "";
                MessageBox.Show("Please ask a Question");
                return;
            }
            if (questionBox.Text.Contains("?") == false)
            {
                answerLabel.Text = "";
                MessageBox.Show("Please ask a Question");
                return;
            }
            int index = random.Next(answers.Count);
            answerLabel.Text = answers[index];
        }
    }
}