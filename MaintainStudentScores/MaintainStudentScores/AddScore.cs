using System.ComponentModel;

namespace MaintainStudentScores;

public partial class AddScore : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string AddStudentScore { get; private set; }
    
    public AddScore()
    {
        InitializeComponent();
    }
    // function to close AddScore form when click on cancel button
    private void btnAddCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    // function to add a new score when clicking 
    private void btnAddScore_Click(object sender, EventArgs e)
    {
        // if statement to check if the value entered is a numerical value
        if (!decimal.TryParse(txtAddscore.Text, out decimal result) || result < 0 || result > 100)
        {
            txtAddscore.Clear(); // clear the txt field since the input is invalid
            // if not a message box will e displayed
            MessageBox.Show("Please enter a valid numeric score between 0 and 100.",
                "Invalid score input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        AddStudentScore = txtAddscore.Text; // create a new instance of the Score to return to UpdateStudent Form
        DialogResult = DialogResult.OK; // set the return of the value to true
        Close(); // close the form
    }
}