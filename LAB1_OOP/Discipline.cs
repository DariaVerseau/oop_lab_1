namespace LAB1_OOP;

public class Discipline
{
    public Guid DisciplineId { get; init; } = Guid.NewGuid();
    public string DisciplineName{ get; set; }
    public string DisciplineDiscription{ get; set; }
    public Lecturer Teacher{ get; set; }
    
    public List<Discipline> DisciplineList { get; set; } = new List<Discipline>();

    public Discipline AddDiscipline(Discipline discipline)
    {
        //Add discipline for student course 
        Console.WriteLine("Enter discipline name: ");
        discipline.DisciplineName = Console.ReadLine();
    
        Console.WriteLine("Enter discription about discipline: ");
        discipline.DisciplineDiscription = Console.ReadLine();
        DisciplineList.Add(discipline);
        
        return discipline;
        
    }

    public void UpdateDiscipline(Guid disciplineId)
    {
        Discipline disciplineToUpdate = DisciplineList.FirstOrDefault(d => d.DisciplineId == disciplineId);
        if (disciplineToUpdate != null)
        {
            disciplineToUpdate.DisciplineName = DisciplineName;
            disciplineToUpdate.DisciplineDiscription = DisciplineDiscription;
            disciplineToUpdate.Teacher = Teacher;
        }
    }

    public void RemoveDiscipline(Guid disciplineId)
    {
        var discipline = DisciplineList.FirstOrDefault(d => d.DisciplineId == DisciplineId);
        if (discipline != null) DisciplineList.Remove(discipline);
    }

    //public Discipline(string disciplineName, string disciplineDiscription, Lecturer teacher)
    //{
       // DisciplineName = disciplineName;
       // DisciplineDiscription = disciplineDiscription;
       // Teacher = teacher;
    //}

    public void PrintDiscipline()
    {
        Console.WriteLine($"Discipline Name: {DisciplineName}");
        Console.WriteLine($"Discipline description: {DisciplineDiscription}");
        Console.WriteLine($"Teacher: {Teacher}");
    }
} 