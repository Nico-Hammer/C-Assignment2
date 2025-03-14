using System.ComponentModel;
using System.Text.RegularExpressions;

namespace MaintainStudentScores;

public partial class AddNewStudent : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Student NewStudent { get; private set; } // initialize a new student object

    public AddNewStudent()
    {
        InitializeComponent();
    }

    /* functionality to close the AddNewStudent form when the cancel button is clicked */
    private void btnNewCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    
    /* functionality to add the new student once info is entered and the user clicks the Ok button */
    private void btnNewOk_Click(object sender, EventArgs e)
    {
        string[] nameParts = txtNewName.Text.Split(' '); // create an array for the name and split on space to get the first and last names
        /* make sure the user enters a first name and a last name */
        if (nameParts.Length < 2)
        {
            MessageBox.Show("Please enter a full name (First and Last).", 
                    "Name Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return; // return to the form so that the invalid student object isnt added to the list
        }
        
        string firstName = nameParts[0]; // set the first name to the first element in the nameParts array (first name)
        string lastName = string.Join(" ", nameParts.Skip(1)); // join the firstname with the last name, skipping over the first name since we already have it
        
        /* make sure that the names entered are valid alphabet characters */
        if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$") || Regex.IsMatch(lastName, @"^[A-Za-z]+\s?,[A-Za-z]+$"))
        {
            MessageBox.Show("Name must contain only letters","Name Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return; // return to form so that the invalid student object isnt added to the list
        }
        List<decimal> scores; // create the scores list
        /* try to parse a decimal from the NewScores textbox */
        try
        {
            scores = txtNewScores.Text
                .Split(' ') // remove the spaces from input
                .Where(s => !string.IsNullOrWhiteSpace(s)) // make sure the input is not null or whitespace
                .Select(decimal.Parse) // get the decimal value
                .ToList(); // add it to the scores list
        }
        /* if its not a valid number show a messagebox to inform the user */
        catch
        {
            MessageBox.Show("Please enter a valid numeric score between 0 and 100.",
                "Invalid score input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        NewStudent = new Student(firstName, lastName, scores); // create the new student object with the user-entered data
        DialogResult = DialogResult.OK; // check if the form is still open
        Close(); // close the form
    }

    /* functionality to add the user-entered score to the students score list when the AddScore button is clicked */
    private void btnNewAddScore_Click(object sender, EventArgs e)
    {
        string newScore = txtNewScore.Text; // get the new score to be added
        /* try to parse a double from the newScore string and show a messagebox if the input is not a valid number */
        if (!double.TryParse(newScore, out double result) || result < 0 || result > 100)
        {
            MessageBox.Show("Please enter a valid numeric score between 0 and 100.",
                            "Invalid score input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        /* if the user enters any whitespace after the score add the score, otherwise add the score and a space */
        txtNewScores.Text = string.IsNullOrWhiteSpace(txtNewScores.Text) // add the score to the NewScores textbox
            ? newScore 
            : txtNewScores.Text + " " + newScore;
        
        txtNewScore.Clear(); // clear the newScores textbox once a valid number is added to the list
    }

    /* functionality to clear the students scores when the ClearScores button is clicked */
    private void btnNewClearScores_Click(object sender, EventArgs e)
    {
        txtNewScores.Clear(); // clear the NewScores textbox
    }
}