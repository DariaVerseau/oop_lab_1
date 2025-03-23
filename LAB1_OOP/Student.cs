namespace LAB1_OOP;

public class Student : Person
{
    public string GroupNumber { get; set; }
    public Course StudentCourse { get; set; } = new Course();
    
    public override void InputDataPerson(Person student)
    {
        Console.WriteLine("Enter information about Student: ");
        base.InputDataPerson(student);
        
        Student s = (Student)student;
        
        Console.WriteLine("Enter group number: ");
        s.GroupNumber = Console.ReadLine();
        
        //Course Info
        s.StudentCourse.InputCourse(StudentCourse);
        
    } 
    
    public void AddStudent(Student? student)
    {
        GlobalData.studentList.Add(student);
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
    
    public void UpdateStudent(Guid studentId)
    {
        Student? studentToUpdate = SearchStudent(studentId);
        InputDataPerson(studentToUpdate); //обновление как student
    }
    
    public void RemoveStudent(Guid studentId)
    {
        Student? studentToRemove = SearchStudent(studentId);
        GlobalData.studentList.Remove(studentToRemove);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Group number: {GroupNumber}");
        StudentCourse.PrintCourse();
        Console.WriteLine("\n");
    }
    
    
}
