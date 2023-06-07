namespace NosovDiplom
{
    public partial class EnterForm : Form
    {

        public EnterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int GetProfitInput()
        {
            return Convert.ToInt32(ProfitInput.Text);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            OutputForm Output = new OutputForm();
            Output.Show();
            Output.ShowTurnoverGrowth(Convert.ToInt32(TurnoverInput.Text));
            Output.ShowContactWaitBoxGrowth(Convert.ToInt32((textBox2.Text)));
            Output.ShowZPRas(Convert.ToInt32((textBox3.Text)));
            Output.ShowMainFonds(Convert.ToInt32((textBox4.Text)));
            Output.ShowSredstva(Convert.ToInt32((textBox5.Text)));
            Output.ShowProfit(Convert.ToInt32((ProfitInput.Text)));
            Output.ShowCountOfWorkers(Convert.ToInt32((textBox7.Text)));

        }
    }
}