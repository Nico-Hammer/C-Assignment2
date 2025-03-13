namespace MaintainStudentScores;

public class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public List<Decimal> score {get; set;}

    public Student(string firstName, string lastName, List<decimal> score)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.score = score;
    }
}