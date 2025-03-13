namespace MaintainStudentScores;

public partial class UpdateStudent : Form
{
    private Student selectedStudent;
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
        addScore.ShowDialog();
    }

    private void btnUpdateupdate_Click(object sender, EventArgs e)
    {
        string selectedScore = lstUpdateScores.SelectedItem.ToString();
        UpdateScore updateScoreForm = new UpdateScore(selectedScore);
        
        if (updateScoreForm.ShowDialog() == DialogResult.OK)
        {
            lstUpdateScores.Items[lstUpdateScores.SelectedIndex] = updateScoreForm.UpdatedStudentScore;
        }
    }
}