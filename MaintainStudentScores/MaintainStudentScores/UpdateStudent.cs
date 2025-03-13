namespace MaintainStudentScores;

public partial class UpdateStudent : Form
{
    public UpdateStudent()
    {
        InitializeComponent();
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
        UpdateScore updateScore = new UpdateScore();
        updateScore.ShowDialog();
    }
}