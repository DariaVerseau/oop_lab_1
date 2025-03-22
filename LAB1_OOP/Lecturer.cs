namespace LAB1_OOP;

public class Lecturer : Person
{
    public string AcademicTitle{get; set;} = "Academic Title";
    
    public List<Discipline> LecturerDiscipline = new List<Discipline>();


    public override dynamic? InputDataPerson(dynamic? lecturer)
    {
        Console.WriteLine("Enter information about Lecturer: ");
        
        //Lecturer personal data 
        base.InputDataPerson(lecturer);
    
        Console.WriteLine("Enter academic title: ");
        lecturer.AcademicTitle = Console.ReadLine();
        
        //добавление предметов в список дисциплин преподавателя        
        Console.WriteLine("Enter number of lecturer disciplines: ");
        int lecturerDisciplineNumber = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < lecturerDisciplineNumber; i++)
        {
            Discipline discipline = new Discipline();
            discipline = discipline.AddDiscipline(discipline);
            LecturerDiscipline.Add(discipline);
        }
        
        return lecturer;
    }

    public override void UpdatePerson(Guid lecturerId)
    {
        Lecturer? lecturerToUpdate = GlobalData.lecturerList.FirstOrDefault(l => l.Id == Id);
        if (lecturerToUpdate != null)
        {
            base.UpdatePerson(lecturerId);
            lecturerToUpdate.AcademicTitle = AcademicTitle;
            lecturerToUpdate.LecturerDiscipline = LecturerDiscipline;
        }
        else Console.WriteLine("Person not found");
    }

    public void InputUpdateLecturer(Guid lecturerId)
    {
        Lecturer? lecturerToUpdate = SearchLecturer(lecturerId);
        InputDataPerson(lecturerToUpdate);
    }

    public static Lecturer? AddLecturer(Lecturer? lecturer)
    {
        GlobalData.lecturerList.Add(lecturer);
        GlobalData.personList.Add(lecturer);

        return lecturer;
    }

    public Lecturer? SearchLecturer(Guid lecturerId)
    {
        Lecturer? lecturerToSearch = GlobalData.lecturerList.FirstOrDefault(l => l.Id == Id);
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

    public void RemoveLecturer(Lecturer? lecturer)
    {
        base.RemovePerson(lecturer);
        GlobalData.lecturerList.Remove(lecturer);
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\nУченое звание:  {AcademicTitle}, \nСписок преподаваемых дисциплин: {LecturerDiscipline}");
    }
     
}