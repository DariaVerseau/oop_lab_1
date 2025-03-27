namespace LAB1_OOP;

public class Lecturer : Person
{
    public string AcademicTitle{get; set;} = "Academic Title";
    
    public List<Discipline> LecturerDiscipline = new List<Discipline>();


    public override void InputDataPerson(Person lecturer)
    {
        Console.WriteLine("Enter information about Lecturer: ");
        
        //Lecturer personal data 
        base.InputDataPerson(lecturer);
        
        Lecturer l = (Lecturer)lecturer;
    
        Console.WriteLine("Enter academic title: ");
        l.AcademicTitle = Console.ReadLine();
        
        //добавление предметов в список дисциплин преподавателя        
        Console.WriteLine("Enter number of lecturer disciplines: ");
        int lecturerDisciplineNumber = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < lecturerDisciplineNumber; i++)
        {
            Discipline discipline = new Discipline();
            Console.WriteLine("Enter id discipline: ");
            Guid disciplineId = Guid.Parse(Console.ReadLine());
            discipline = discipline.SearchDiscipline(disciplineId);
            LecturerDiscipline.Add(discipline);
        }
        
    }

    public void UpdateLecturer(Guid lecturerId)
    {
        Lecturer? lecturerToUpdate = SearchLecturer(lecturerId);
        InputDataPerson(lecturerToUpdate);
    }
    

    public  Lecturer? AddLecturer(Lecturer? lecturer)
    {
        GlobalData.lecturerList.Add(lecturer);
        return lecturer;
    }

    public Lecturer? SearchLecturer(Guid lecturerId)
    {
        Lecturer? lecturerToSearch = GlobalData.lecturerList.FirstOrDefault(l => l.Id == lecturerId);
        if (lecturerToSearch != null)
        {
            Console.WriteLine("Lecturer has been found ");
            return lecturerToSearch;
        }

        else
        {
            Console.WriteLine("Lecturer not found");
            return null;
        }
        
    }

    public void RemoveLecturer(Guid lecturerId)
    {
        Lecturer? lecturerToRemove = SearchLecturer(lecturerId);
        GlobalData.lecturerList.Remove(lecturerToRemove);
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\nУченое звание:  {AcademicTitle}, \nСписок преподаваемых дисциплин: ");
        LecturerDiscipline.ForEach(ld => Console.WriteLine($"{ld.DisciplineName}\n"));
    }
     
}