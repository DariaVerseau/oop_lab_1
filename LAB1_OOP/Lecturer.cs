namespace LAB1_OOP;

public class Lecturer : Person
{
    public string AcademicTitle{get; set;}
    
    public List<Discipline> LecturerDiscipline { get; set; } = new List<Discipline>();
    
    //вынести списки отдельно 
    public List<Lecturer> LecturerList { get; set; } = new List<Lecturer>();
    
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

    public Lecturer addLecturer(Lecturer lecturer)
    {
        Console.WriteLine("Enter information about Lecturer: ");
        lecturer = (Lecturer)AddPerson(lecturer);
    
        Console.WriteLine("Enter academic title: ");
        lecturer.AcademicTitle = Console.ReadLine();
        
        //добавление предметов в список дисциплин преподавателя        
        Console.WriteLine("Enter number of lecturer disciplines: ");
        int lecturerDisciplineNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < lecturerDisciplineNumber; i++)
        {
            Discipline discipline = new Discipline();
            discipline = discipline.AddDiscipline(discipline);
            LecturerDiscipline.Add(discipline);
        }
        
        LecturerList.Add(lecturer);
        PersonList.Add(lecturer);

        return lecturer;
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