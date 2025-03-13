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

    private void btnAddCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnAddaddscore_Click(object sender, EventArgs e)
    {
        AddStudentScore = txtAddscore.Text;
        DialogResult = DialogResult.OK;
        Close();
    }
}