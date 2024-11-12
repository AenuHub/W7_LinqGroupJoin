using W7_LinqGroupJoin;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(1, "Ali", 1),
            new Student(2, "Ayşe", 2),
            new Student(3, "Mehmet", 1),
            new Student(4, "Fatma", 3),
            new Student(5, "Ahmet", 2)
        };

        List<Class> classes = new List<Class>()
        {
            new Class(1, "Matematik"),
            new Class(2, "Türkçe"),
            new Class(3, "Kimya")
        };

        var result = classes.GroupJoin(
            students,
            classes => classes.ClassId,
            students => students.ClassId,
            (classes, studentsGroup) => new
            {
                ClassName = classes.ClassName,
                Students = studentsGroup
            }
        );

        foreach (var @class in result)
        {
            Console.WriteLine($"{@class.ClassName} - {@class.Students.Count()} students:");
            foreach (var student in @class.Students)
            {
                Console.WriteLine($"{student.StudentName}");
            }
            Console.WriteLine(new string('-', 20));
        }
        
        Console.ReadKey();
    }
}