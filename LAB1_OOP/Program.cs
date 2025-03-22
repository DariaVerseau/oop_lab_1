using LAB1_OOP;

var student1 = new Student();

student1.UpdatePerson(student1.Id);

student1.PrintInfo();
PrintInfoList();



void PrintInfoList()
{
    GlobalData.personList.ForEach(personList => personList.PrintInfo());
    Console.WriteLine();
    GlobalData.studentList.ForEach(studentList => studentList.PrintInfo());
    Console.WriteLine();
    GlobalData.lecturerList.ForEach(lecturerList => lecturerList.PrintInfo());
    Console.WriteLine();
    GlobalData.disciplineList.ForEach(disciplineList => disciplineList.PrintDiscipline());
    Console.WriteLine();
    GlobalData.personList.ForEach(personList => personList.PrintInfo());
}



//в процессе разработки :)
 