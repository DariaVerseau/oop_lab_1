namespace LAB1_OOP;

public class Student : Person
{
    public Guid StudentId { get; set; } = Person.Id;
    public string GroupNumber { get; set; }
    public Course StudentCourse { get; set; } = new Course();
    public static List<Student> StudentList { get; } = new List<Student>();

    public Student(string firstName, string lastName, string middleName, int age, string groupNumber, Course course) :
        base( firstName, lastName, middleName, age)
    {
        Id = Person.Id;
        GroupNumber = groupNumber; 
        StudentCourse = course;
    }
    
    private void AddStudent(Student student)
    {
        StudentList.Add(student);
        PersonList.Add(student);
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
    
}