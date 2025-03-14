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
        if (!decimal.TryParse(txtAddscore.Text, out decimal result) || result < 0 || result > 100)
        {
            MessageBox.Show("Please enter a valid numeric score between 0 and 100.",
                "Invalid score input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        AddStudentScore = txtAddscore.Text;
        DialogResult = DialogResult.OK;
        Close();
    }
}