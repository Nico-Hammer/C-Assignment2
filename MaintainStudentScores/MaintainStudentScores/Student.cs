namespace MaintainStudentScores;

/* student class */
public class Student
{
    public string firstName { get; set; } // students first name
    public string lastName { get; set; } // students last name
    public List<Decimal>? score {get; set;} // list of students scores, it's nullable since we can create students with no scores

    /* student object constructor */
    public Student(string firstName, string lastName, List<decimal>? score)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.score = score ?? new List<decimal>();
    }
}