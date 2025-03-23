namespace LAB1_OOP;

public static class GlobalData
{
    public static List<Lecturer?> lecturerList = new List<Lecturer?>();
    public static List<Student?> studentList  = new List<Student?>();
    public static List<Discipline> disciplines = new List<Discipline>();
    public static List<Course?> courseList = new List<Course?>();
    
    public static void PrintInfoList()
    {
        GlobalData.studentList.ForEach(studentList => studentList.PrintInfo());
        Console.WriteLine();
        GlobalData.lecturerList.ForEach(lecturerList => lecturerList.PrintInfo());
        Console.WriteLine();
        GlobalData.disciplines.ForEach(disciplineList => disciplineList.PrintDiscipline());
    }
    
}


//PrintInfoList();