namespace MaintainStudentScores;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
        AddNewStudent newStudent= new AddNewStudent();
        newStudent.ShowDialog();
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}