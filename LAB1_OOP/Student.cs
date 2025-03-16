namespace LAB1_OOP;

public class Student : Person
{
    public string GroupNumber { get; set; }
    public Course StudentCourse { get; set; } = new Course();
    public List<Student> StudentList { get; set; } = new List<Student>();
    
    public Student AddStudent(Student student)
    {
        Console.WriteLine("Enter information about Student: ");
        //Student personal data
        student = (Student)AddPerson(student);
        
        Console.WriteLine("Enter group number: ");
        student.GroupNumber = Console.ReadLine();
        //Course Info
        student.StudentCourse.AddDisciplineCourse(StudentCourse);
        
        
        //Console.WriteLine("Enter course number: ");
        //student.StudentCourse.CourseNumber = int.Parse(Console.ReadLine());
        
        //Discipline discipline = new Discipline();
        //student.StudentCourse.AddDisciplineCourse(discipline);
        
        StudentList.Add(student);
        PersonList.Add(student);
        return student;
    }

    public override void UpdatePerson(Guid studentId)
    {
        Student studentToUpdate = StudentList.FirstOrDefault(s => s.Id == studentId);
        if (studentToUpdate != null)
        {
            base.UpdatePerson(studentId);
            studentToUpdate.GroupNumber = GroupNumber;
            studentToUpdate.StudentCourse = StudentCourse;
        }

    }

    public override void RemovePerson(Guid id)
    {
        Student student = StudentList.FirstOrDefault(s => s.Id == id);
        if (student != null) StudentList.Remove(student);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Group number: {GroupNumber}");
        StudentCourse.PrintCourse();
        Console.WriteLine("\n");
    }

    public void PrintInfoStudentList()
    {
        StudentList.ForEach(studentList => studentList.PrintInfo());
    }
    
}