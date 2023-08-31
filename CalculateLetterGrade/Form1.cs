namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);

            String letterGrade = "";

            if (numberGrade >= 90)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 89)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 70 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 69)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
