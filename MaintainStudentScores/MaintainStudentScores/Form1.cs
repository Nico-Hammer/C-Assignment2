namespace MaintainStudentScores;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        List<Student> students = new List<Student>
        {
            new() { firstName = "Joel", lastName = "Murach", score = new List<Decimal> { 97, 91, 83 } },
            new() { firstName = "Doug", lastName = "Lowe", score = new List<Decimal> { 99, 93, 97 } },
            new() { firstName = "Anne", lastName = "Boehm", score = new List<Decimal> { 100, 100, 100 } },
        };
        printStudents(students);
    }

    private void printStudents(List<Student> students)
    {
        foreach (Student s in students)
        {
            string studentscoreinfo = "";
            foreach (Decimal score in s.score)
            {
                studentscoreinfo += $"{score}|";
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
    private void btnUpdateStudent_Click(object sender, EventArgs e)
    {
        UpdateStudent updateStudent = new UpdateStudent();
        updateStudent.ShowDialog();
    }
    private void btnDeleteStudent_Click(object sender, EventArgs e)
    {
        lstStudents.Items.Remove(lstStudents.Items[lstStudents.SelectedIndex]);
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedStudent = lstStudents.SelectedItem.ToString();
        var scores = selectedStudent.Split("|")
                                                .Skip(1)
                                                .Where(s => !string.IsNullOrWhiteSpace(s))
                                                .Select(decimal.Parse).ToList();
        
        txtScoreTotal.Text = Math.Round(scores.Sum(), 2).ToString();;
        txtCount.Text = scores.Count.ToString();
        txtStudentAVG.Text = Math.Round(scores.Average(), 2).ToString();
    }
}