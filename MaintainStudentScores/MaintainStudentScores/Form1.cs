namespace MaintainStudentScores;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        List<Student> samplestudents = new List<Student>
        {
            new() {firstName = "Joel",lastName = "Murach",score = [97,91,83]},
            new() {firstName = "Doug",lastName = "Lowe",score = [99,93,97]},
            new() {firstName = "Anne",lastName = "Boehm",score = [100,100,100]},
        };
        
        foreach (Student s in samplestudents)
        {
            string studentscoreinfo = "";
            foreach (Student sc in samplestudents)
            {
                for (int h = 0; h < samplestudents.Count; h++)
                {
                    studentscoreinfo += $"{sc.score[h].ToString()}|";
                }
            }
            string fullstudentinfo = $"{s.firstName} {s.lastName}|{studentscoreinfo}";
            lstStudents.Items.Add(fullstudentinfo);
        }
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