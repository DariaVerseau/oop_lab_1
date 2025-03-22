namespace LAB1_OOP;

public class Student : Person
{
    public string GroupNumber { get; set; }
    public Course StudentCourse { get; set; } = new Course();
    
    public override dynamic? InputDataPerson(dynamic? student)
    {
        Console.WriteLine("Enter information about Student: ");
        
        //Student personal data 
        base.InputDataPerson(student);
        
        Console.WriteLine("Enter group number: ");
        student.GroupNumber = Console.ReadLine();
        
        //Course Info
        student.StudentCourse.AddDisciplineCourse(StudentCourse);
        
        return student;
    } 
    

    public void AddStudent(Student? student)
    {
        GlobalData.studentList.Add(student);
        GlobalData.personList.Add(student);
    }
    
    public Student? SearchStudent(Guid studentId)
    {
        Student? studentToSearch = GlobalData.studentList.FirstOrDefault(s => s.Id == Id);
        if (studentToSearch != null)
        {
            Console.WriteLine("Student has been found ");
            return studentToSearch;
        }

        else
        {
            Console.WriteLine("Student not found");
            return null;
        }
        
    }


    public override void UpdatePerson(Guid studentId)
    {
        Student? studentToUpdate = SearchStudent(studentId);
        
        base.UpdatePerson(studentId);
        studentToUpdate.GroupNumber = GroupNumber;
        studentToUpdate.StudentCourse = StudentCourse;
            
    }

    public void InputUpdateStudent(Guid studentId)
    {
        Student? studentToUpdate = SearchStudent(studentId);
        InputDataPerson(studentToUpdate);
    }

    public override void RemovePerson(dynamic? student)
    {
        base.RemovePerson(student);
        GlobalData.studentList.Remove(student);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Group number: {GroupNumber}");
        StudentCourse.PrintCourse();
        Console.WriteLine("\n");
    }
    
    
}
