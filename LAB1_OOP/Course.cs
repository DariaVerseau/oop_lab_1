namespace LAB1_OOP;

public class Course
{
    public Guid CourseId { get; } = Guid.NewGuid();
    public int CourseNumber { get; set; } 
    public List<Discipline?> CourseDisciplineList  = new List<Discipline?>();

    //метод добавления, удаления предмета по айди группы

    
    public Course? InputCourse(Course? course)
    {
        Console.WriteLine("Enter course number: ");
        course.CourseNumber = int.Parse(Console.ReadLine() ?? string.Empty);
        
        return course;
    }

    public void AddCourse(Course? course)
    {
        GlobalData.courseList.Add(course);
    }
    
    public Course? SearchCourse(Guid courseId)
    {
        Course? courseToSearch = GlobalData.courseList.FirstOrDefault(c => c.CourseId == CourseId);
        if (courseToSearch != null)
        {
            Console.WriteLine("Course has been found ");
            return courseToSearch;
        }

        else
        {
            Console.WriteLine("Course not found");
            return null;
        }
    }

    public Discipline? SearchDisciplineCourse(Guid disciplineId)
    {
        Discipline? disciplineToSearch = CourseDisciplineList.FirstOrDefault(d => d.DisciplineId == disciplineId);
        if (disciplineToSearch != null)
        {
            Console.WriteLine("Discipline has been found ");
            return disciplineToSearch;
        }

        else
        {
            Console.WriteLine("Discipline not found");
            return null;
        }
    }
    
    public void AddDisciplineCourse(Guid courseId, Discipline? discipline)
    {
        Course? course = SearchCourse(courseId);
        //добавление дисциплины с вводом в список диссциплин
        course.CourseDisciplineList.Add(discipline);
    }

    public void UpdateCourse(Guid courseId)
    {
        Course? courseToUpdate = SearchCourse(courseId);
        if (courseToUpdate != null) courseToUpdate.CourseNumber = CourseNumber;
    }

    public void InputUpdateCourse(Guid courseId)
    {
        InputCourse(SearchCourse(courseId));
    }
    
    public void RemoveCourse(Course? courseToRemove)
    {
        GlobalData.courseList.Remove(courseToRemove);
    }
    
    
    public void PrintCourse()
    {
        Console.WriteLine($"Course number:  {CourseNumber}");
        CourseDisciplineList.ForEach(courseDiscipline => Console.WriteLine($"Discipline name: {courseDiscipline.DisciplineName}"));
    }
}