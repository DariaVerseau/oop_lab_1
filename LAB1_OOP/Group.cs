namespace LAB1_OOP;

public class Group
{
    public string GroupName { get; set; } 
    /*
     Dictionary<int, string> groups = new Dictionary<int, string>(){
         [1] = "ТСО-105Б-24",
         [2] = "ТСО-205Б-23",
         [3] =  "ТСО-305Б-22",
         [4] = "ТСО-405Б-21"
    };
     */
    //public List<Student> GroupList = new List<Student>();
    
    public static Dictionary<string, List<Student>> GroupStudent = new Dictionary<string, List<Student>>()
    {
        {"ТСО-105Б-24", []},
        {"ТСО-205Б-23", []},
        {"ТСО-305Б-22", []},
        {"ТСО-405Б-21", []}
    };

    public void addStudentToGroup(Student student)
    {
        int courseNumber = student.StudentCourse.CourseNumber;
        switch (courseNumber)
        {
            case 1:
                GroupStudent["ТСО-105Б-24"].Add(student);
                break; 
            case 2:
                GroupStudent["ТСО-205Б-23"].Add(student);
                break; 
            case 3:
                GroupStudent["ТСО-305Б-22"].Add(student);
                break; 
            case 4:
                GroupStudent["ТСО-405Б-21"].Add(student);
                break; 
        }
    }

    public static void PrintStudentGroup()
    {
        foreach(var person in GroupStudent)
        {
            //Console.WriteLine($"key: {person.Key}  value: {person.Value}");
            Console.WriteLine($"key: {person.Key}  value: ");
            person.Value.ForEach(groupList => groupList.PrintInfo());
        }
    }
}