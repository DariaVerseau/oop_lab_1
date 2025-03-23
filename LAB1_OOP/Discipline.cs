namespace LAB1_OOP;

public class Discipline
{
    public Guid DisciplineId { get; } = Guid.NewGuid();
    public string? DisciplineName{ get; set; } 
    public string? DisciplineDiscription{ get; set; }
    public Lecturer? Teacher { get; set; } = new Lecturer();


    public void InputDataDiscipline(Discipline? discipline)
    {
        //Add discipline for student course 
        Console.WriteLine("Enter discipline name: ");
        if (discipline != null)
        {
            discipline.DisciplineName = Console.ReadLine();

            Console.WriteLine("Enter description about discipline: ");
            discipline.DisciplineDiscription = Console.ReadLine();

            //teacher info
            Lecturer? lecturer = discipline.Teacher;
            Teacher = Lecturer.AddLecturer(lecturer);
        }
        //return discipline;
    }

    public Discipline AddDiscipline(Discipline discipline)
    {
        //add discipline to list   
        GlobalData.disciplineList.Add(discipline);
        
        return discipline;
    }

    public Discipline? SearchDiscipline(Guid disciplineId)
    {
        var disciplineToSearch = GlobalData.disciplineList.FirstOrDefault(d => d.DisciplineId == DisciplineId);
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

    public void UpdateDiscipline(Guid disciplineId)
    {
        Discipline? disciplineToUpdate = SearchDiscipline(disciplineId);
        if (disciplineToUpdate != null)
        {
            disciplineToUpdate.DisciplineName = DisciplineName;
            disciplineToUpdate.DisciplineDiscription = DisciplineDiscription;
            disciplineToUpdate.Teacher = Teacher;
        }
    }

    public void UpdateInputDataDiscipline(Guid disciplineId)
    {
        InputDataDiscipline(SearchDiscipline(disciplineId));
    }

    public void RemoveDiscipline(Discipline discipline)
    {
        GlobalData.disciplineList.Remove(discipline);
    }

 
    public void PrintDiscipline()
    {
        Console.WriteLine($"Discipline Name: {DisciplineName}");
        Console.WriteLine($"Discipline description: {DisciplineDiscription}");
        Console.WriteLine($"Teacher: {Teacher}");
    }
} 