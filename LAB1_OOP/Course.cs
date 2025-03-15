namespace LAB1_OOP;

public class Course
{
    public Guid CourseId { get; init; } = Guid.NewGuid();
    public string CourseNumber { get; set; }
     
    public static List<Discipline> CourseDisciplineList { get; set; } = new List<Discipline>();

    public Course(Guid courseId, string courseNumber, List<Discipline>? disciplines = null)
    {
        CourseId = courseId;     
        CourseNumber = courseNumber;
        CourseDisciplineList = disciplines ?? new List<Discipline>();
    }
     
}