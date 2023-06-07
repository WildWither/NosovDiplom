namespace NosovDiplom
{
    public partial class OutputForm : Form
    {
        private const int LastYearTurnover = 16000000;
        private const int LastYearCon = 71230;
        private const int LastYearZPlost = 13579373;
        private const int LastYearFonds = 89;

        public OutputForm()
        {
            InitializeComponent();
            this.Hide();
        }

        public void ShowTurnoverGrowth(int Turnover)
        {
            TradeTurnoverResultBox.Text = ConvertToOutput(BuhMathf.GetGrowth(LastYearTurnover, Turnover));
        }

        public void ShowContactWaitBoxGrowth(int x)
        {
            ContactWaitBox.Text = ConvertToOutput(BuhMathf.GetGrowth(LastYearCon, x));
        }

        public void ShowZPRas(int x)
        {
            textBox2.Text = ConvertToOutput(BuhMathf.GetGrowth(LastYearZPlost, x));
        }

        public void ShowMainFonds(int x)
        {
            textBox3.Text = ConvertToOutput(BuhMathf.GetGrowth(LastYearFonds, x));
        }

        public void ShowSredstva(int x)
        {
            textBox4.Text = ConvertToOutput(BuhMathf.GetGrowth(4500000, x));
        }

        public void ShowProfit(int x)
        {
            textBox5.Text = ConvertToOutput(BuhMathf.GetGrowth(22000000, x));
        }

        public void ShowCountOfWorkers(int x)
        {
            textBox6.Text = ConvertToOutput(BuhMathf.GetGrowth(5000, x));
        }

        private string ConvertToOutput(float x)
        {
            return x.ToString() + " % ";
        }














        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
