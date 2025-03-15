namespace LAB1_OOP;

public class Lecturer : Person
{
    public string AcademicTitle{get; set;}
    
    public List<Discipline> LecturerDiscipline { get; set; } = new List<Discipline>();
    
    public static List<Lecturer> LecturerList { get; } = new List<Lecturer>();
    
    public Lecturer(string firstName, string lastName, string middleName,int age, string AcademicTitle, List<string> lecturerDisciplines) : base(firstName, lastName, middleName, age)
    {
        this.AcademicTitle = AcademicTitle;
        this.LecturerDiscipline = LecturerDiscipline;
    }
    
    public override void UpdatePerson(Guid lecturerId)
    {
        Lecturer lecturerToUpdate = LecturerList.FirstOrDefault(l => l.Id == Id);
        if (lecturerToUpdate != null)
        {
            base.UpdatePerson(lecturerId);
            lecturerToUpdate.AcademicTitle = AcademicTitle;
            lecturerToUpdate.LecturerDiscipline = LecturerDiscipline;
        }
    }

    private void addLecturer(Lecturer lecturer)
    {
        LecturerList.Add(lecturer);
        PersonList.Add(lecturer);
    }

    private void removeLecturer(Guid lecturerId)
    {
        Lecturer lecturer = LecturerList.FirstOrDefault(l => l.Id == Id);
        LecturerList.Remove(lecturer);
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\nУченое звание:  {AcademicTitle}, \nСписок преподаваемых дисциплин: {LecturerDiscipline}");
    }
     
}