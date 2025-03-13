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
        this.Close();
    }

    private void btnUScoreupdate_Click(object sender, EventArgs e)
    {
        UpdatedStudentScore = txtUScore.Text;
        DialogResult = DialogResult.OK;
        Close();
    }
}