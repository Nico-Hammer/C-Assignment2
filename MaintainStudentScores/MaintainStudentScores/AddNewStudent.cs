namespace MaintainStudentScores;

public partial class AddNewStudent : Form
{
    public AddNewStudent()
    {
        InitializeComponent();
    }

    private void btnNewCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnNewOk_Click(object sender, EventArgs e)
    {
        string name = txtNewName.Text;
    }

    private void btnNewAddScore_Click(object sender, EventArgs e)
    {
        string newScore = txtNewScore.Text;
        if (!double.TryParse(newScore, out double result) || result < 0 || result > 100)
        {
            MessageBox.Show("Please enter a valid numeric score between 0 and 100.",
                            "Invalid score input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        txtNewScores.Text = string.IsNullOrWhiteSpace(txtNewScores.Text) 
            ? newScore 
            : txtNewScores.Text + " " + newScore;
        
        txtNewScore.Clear();
    }

    private void btnNewClearScores_Click(object sender, EventArgs e)
    {
        txtNewScores.Clear();
    }
}