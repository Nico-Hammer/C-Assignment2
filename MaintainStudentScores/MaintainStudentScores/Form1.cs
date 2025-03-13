namespace MaintainStudentScores;
public partial class Form1 : Form
{
    private List<Student> students = new List<Student>();
    public Form1()
    {
        InitializeComponent();
    }

    private void LoadSample()
    {
        students.Add(new Student("Joel", "Murach", [ 97, 91, 83 ]));
        students.Add(new Student("Doug", "Lowe", [ 99, 93, 97 ]));
        students.Add(new Student("Anne", "Boehm", [ 100, 100, 100 ]));
        PrintStudents(students);
    }

    private void PrintStudents(List<Student> students)
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
        AddNewStudent newStudentForm = new AddNewStudent();
        if (newStudentForm.ShowDialog() == DialogResult.OK)
        {
            lstStudents.Items.Clear();
            Student newStudent = newStudentForm.NewStudent;
            students.Add(newStudent);
            PrintStudents(students);
        }
    }
    
    private void btnUpdateStudent_Click(object sender, EventArgs e)
    {
        if (lstStudents.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a student to update.", 
                "Student not selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string selectedStudent = lstStudents.SelectedItem.ToString();
        var parts = selectedStudent.Split("|");

        if (parts.Length < 2) return;

        string[] nameParts = parts[0].Split(" ");
        string firstName = nameParts[0];
        string lastName = nameParts[1];
    
        var scores = parts.Skip(1)
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .Select(decimal.Parse)
            .ToList();

        Student studentToUpdate = new Student(firstName, lastName, scores);
    
        UpdateStudent updateStudent = new UpdateStudent(studentToUpdate);
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
        
        txtScoreTotal.Text = Math.Round(scores.Sum(), 2).ToString();
        txtCount.Text = scores.Count.ToString();
        txtStudentAVG.Text = Math.Round(scores.Average(), 2).ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        LoadSample();
    }
}