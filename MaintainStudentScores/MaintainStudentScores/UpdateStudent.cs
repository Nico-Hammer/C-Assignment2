namespace MaintainStudentScores;

public partial class UpdateStudent : Form
{
    private Student selectedStudent { get; set;  }

    public UpdateStudent(Student student)
    {
        InitializeComponent();
        selectedStudent = student;
        LoadStudentData();
    }

    private void LoadStudentData()
    {
        txtUpdateName.Text = selectedStudent.firstName + " " + selectedStudent.lastName;
        lstUpdateScores.Items.Clear();

        foreach (decimal score in selectedStudent.score)
        {
            lstUpdateScores.Items.Add(score.ToString());
        }
    }
    
    private void btnUpdateCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnUpdateAdd_Click(object sender, EventArgs e)
    {
        AddScore addScore = new AddScore();
        if (addScore.ShowDialog() == DialogResult.OK)
        {
            selectedStudent.score.Add(decimal.Parse(addScore.AddStudentScore));
            lstUpdateScores.Items.Add(addScore.AddStudentScore);
        }
    }

    private void btnUpdateupdate_Click(object sender, EventArgs e)
    {
        // get the selected score from  the list
        string selectedScore = lstUpdateScores.SelectedItem.ToString();
        // pass the selected value to the UpdateScore Form
        UpdateScore updateScoreForm = new UpdateScore(selectedScore);
        
        // after clicking ok button on the UpdateScore form,
        // the selected score will now have the new updatedScore from the UpdateScore Form
        if (updateScoreForm.ShowDialog() == DialogResult.OK)
        {
            lstUpdateScores.Items[lstUpdateScores.SelectedIndex] = updateScoreForm.UpdatedStudentScore;
        }
    }

    private void btnUpdateRemove_Click(object sender, EventArgs e)
    {
        if (lstUpdateScores.SelectedIndex != -1) // check that the selected score is in the list i.e. exists
        {
            int index = lstUpdateScores.SelectedIndex; // save the inddex of the selected score
            selectedStudent.score.RemoveAt(index); // remove the selected score from the  list
            lstUpdateScores.Items.RemoveAt(index); // remove the selected score from the listbox
            lstUpdateScores.SelectedIndex = -1; // make the selected index invalid since the score no longer exists and cant be accessed
        }
        /* if no score is selected or the selected score is deleted show a messagebox informing to select a score */
        else
        {
            MessageBox.Show("Select a score to delete");
        }
    }

    private void btnUpdateClear_Click(object sender, EventArgs e)
    {
        lstUpdateScores.Items.Clear(); //clear all scores in the list
        selectedStudent.score = new List<decimal>();
    }

    private void btnUpdateOk_Click(object sender, EventArgs e)
    {
        selectedStudent = new Student(selectedStudent.firstName, selectedStudent.lastName, selectedStudent.score);
        DialogResult = DialogResult.OK;
        Close();
    }
}