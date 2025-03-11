namespace MaintainStudentScores;

public class Student
{
    string firstName { get; set; }
    string lastName { get; set; }
    List<Decimal> score = new List<Decimal>();
}