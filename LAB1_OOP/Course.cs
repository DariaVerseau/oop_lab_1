namespace LAB1_OOP;

public class Course
{
    public Guid CourseId { get; init; } = Guid.NewGuid();
    public int CourseNumber { get; set; } 
     
    public List<Discipline> CourseDisciplineList { get; set; } = new List<Discipline>();

    //метод добавления, удаления предмета по айди группы

    public void AddDisciplineCourse(Course course)
    {
        Console.WriteLine("Enter course number: ");
        course.CourseNumber = int.Parse(Console.ReadLine());
        Discipline discipline = new Discipline();
        CourseDisciplineList.Add(discipline.AddDiscipline(discipline));
    }

    public void PrintCourse()
    {
        Console.WriteLine($"Course number:  {CourseNumber}");
        CourseDisciplineList.ForEach(courseDiscipline => Console.WriteLine($"Discipline name: {courseDiscipline.DisciplineName}"));
    }
}