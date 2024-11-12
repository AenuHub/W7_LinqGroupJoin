namespace W7_LinqGroupJoin;

public class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }

    public Class(int classId, string className)
    {
        ClassId = classId;
        ClassName = className;
    }
}