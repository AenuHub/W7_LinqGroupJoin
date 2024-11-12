namespace W7_LinqGroupJoin;

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int ClassId { get; set; }

    public Student(int studentId, string studentName, int classId)
    {
        StudentId = studentId;
        StudentName = studentName;
        ClassId = classId;
    }
}