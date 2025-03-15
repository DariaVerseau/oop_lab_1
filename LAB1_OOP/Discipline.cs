namespace LAB1_OOP;

public class Discipline
{
    public Guid DisciplineId { get; init; } = Guid.NewGuid();
    public string DisciplineName{ get; set; }
    public string DisciplineDiscription{ get; set; }
    public string Teacher{ get; set; } 
    
    public static List<Discipline> DisciplineList { get; } = new List<Discipline>();

    private void AddDiscipline(Discipline discipline)
    {
        DisciplineList.Add(discipline);
    }

    private void UpdateDiscipline(Guid disciplineId)
    {
        Discipline disciplineToUpdate = DisciplineList.FirstOrDefault(d => d.DisciplineId == disciplineId);
        if (disciplineToUpdate != null)
        {
            disciplineToUpdate.DisciplineName = DisciplineName;
            disciplineToUpdate.DisciplineDiscription = DisciplineDiscription;
            disciplineToUpdate.Teacher = Teacher;
        }
    }

    private void RemoveDiscipline(Guid disciplineId)
    {
        var discipline = DisciplineList.FirstOrDefault(d => d.DisciplineId == DisciplineId);
        if (discipline != null) DisciplineList.Remove(discipline);
    }

    public Discipline(string disciplineName, string disciplineDiscription, string teacher)
    {
        DisciplineName = disciplineName;
        DisciplineDiscription = disciplineDiscription;
        Teacher = teacher;
    }
}