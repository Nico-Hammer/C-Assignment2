using System.ComponentModel;

namespace MaintainStudentScores;

public partial class UpdateScore : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string UpdatedStudentScore { get; private set; }
    
    public UpdateScore(string score)
    {
        InitializeComponent();
        txtUScore.Text = score;
    }

    private void btnUScorecancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnUScoreupdate_Click(object sender, EventArgs e)
    {
        if (!double.TryParse(txtUScore.Text, out double result) || result < 0 || result > 100)
        {
            {
                MessageBox.Show("Please enter a valid numeric score between 0 and 100.",
                    "Invalid score input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        UpdatedStudentScore = txtUScore.Text;
        DialogResult = DialogResult.OK;
        Close();
    }
}