namespace MaintainStudentScores;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Student j = new Student();
        Student D = new Student();
        Student A = new Student();
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

    private void btnUpdateStudent_Click(object sender, EventArgs e)
    {
        UpdateStudent updateStudent = new UpdateStudent();
        updateStudent.ShowDialog();
    }
}