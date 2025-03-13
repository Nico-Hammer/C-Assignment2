using System.ComponentModel;

namespace MaintainStudentScores;

public partial class AddNewStudent : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Student NewStudent { get; private set; }

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
        string[] nameParts = txtNewName.Text.Split(' ');
        if (nameParts.Length < 2)
        {
            MessageBox.Show("Please enter a full name (First and Last).", 
                    "Name Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string firstName = nameParts[0];
        string lastName = string.Join(" ", nameParts.Skip(1));
        
        List<decimal> scores;
        try
        {
            scores = txtNewScores.Text
                .Split(' ')
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(decimal.Parse)
                .ToList();
        }
        //since we're using this twice in this file, let's create a method to handle it
        catch
        {
            MessageBox.Show("Please enter a valid numeric score between 0 and 100.",
                "Invalid score input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        NewStudent = new Student(firstName, lastName, scores);
        DialogResult = DialogResult.OK;
        Close();
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