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

    // function to close UpdateScore form when click on cancel button
    private void btnUScorecancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    // function to update a score when clicking 
    private void btnUScoreupdate_Click(object sender, EventArgs e)
    {
        // if statement to check if the value entered is a numerical value
        if (!decimal.TryParse(txtUScore.Text, out decimal result) || result < 0 || result > 100)
        {
            txtUScore.Clear(); // clear the txt field since the input is invalid
            // if not a message box will e displayed
            MessageBox.Show("Please enter a valid numeric score between 0 and 100.",
                "Invalid score input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        UpdatedStudentScore = txtUScore.Text; // create a new instance of the Score to return to UpdateStudent Form
        DialogResult = DialogResult.OK; // set the return of the value to true
        Close(); // close the form
    }
}