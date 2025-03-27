namespace LAB1_OOP;

public static class GlobalData
{
    public static List<Lecturer?> lecturerList = new List<Lecturer?>();
    public static List<Student?> studentList  = new List<Student?>();
    public static List<Discipline> disciplines = new List<Discipline>();
    public static List<Course?> courseList = new List<Course?>();
    
    public static void PrintInfoList()
    {
        studentList.ForEach(studentList => studentList.PrintInfo());
        Console.WriteLine();
        lecturerList.ForEach(lecturerList => lecturerList.PrintInfo());
        Console.WriteLine();
        disciplines.ForEach(disciplineList => disciplineList.PrintDiscipline());
        Console.WriteLine();
        courseList.ForEach(courseList => courseList.PrintCourse());
       
    }

    public static void PrintStudentList()
    {
        studentList.ForEach(studentList => studentList.PrintInfo());
        Console.WriteLine();
    }

    public static void PrintLecturerList()
    {
        lecturerList.ForEach(lecturerList => lecturerList.PrintInfo());
        Console.WriteLine();
    }

    public static void PrintDisciplines()
    {
        disciplines.ForEach(disciplineList => disciplineList.PrintDiscipline());
        Console.WriteLine();   
    }

    public static void PrintCourseList()
    {
        courseList.ForEach(courseList => courseList.PrintCourse());
        Console.WriteLine();
    }
}


//PrintInfoList();