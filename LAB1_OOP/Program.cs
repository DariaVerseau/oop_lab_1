using LAB1_OOP;

/*Person p1 = new() {FirstName = "Мария", LastName = "Иванова", MiddleName = "Ивановна", Age = 18};
Person p2 = new Person();
Person p3 = new() {FirstName = "Валентина", LastName = "Юдашкина", MiddleName = "Алексеевна", Age = 20};
Person p4 = new() {FirstName = "Артур", LastName = "Пирожков", MiddleName = "Александрович", Age = 19};
p2.InputDataPerson(p2);

p1.AddPerson(p1);
//p1.RemovePerson(p1); работает

/*
p2.AddPerson(p2);
p3.AddPerson(p3);
p4.AddPerson(p4);
* /

//или 
GlobalData.personList.AddRange(new[] { p2, p3, p4 });
//обновление данных работает
p1.UpdatePerson(p1.Id);

//проверка поиска людей
//p1.SearchPerson(p1.Id); работает 

Console.WriteLine("List of people:");
GlobalData.personList.ForEach(personList => personList.PrintInfo());
//работает ) */

Lecturer lecturer1 = new() {FirstName = "Игорь", LastName = "Сидоров", MiddleName = "Николаевич", Age = 48, AcademicTitle = "Доцент", LecturerDiscipline = new List<Discipline>()};
Discipline d1 = new() { DisciplineName = "Math", DisciplineDiscription = "Math science", Teacher = lecturer1 };
Discipline d2 = new() { DisciplineName = "Algebra", DisciplineDiscription = "A branch of mathematics that studies general techniques for manipulating quantities, regardless of their numerical values.", Teacher = lecturer1 };
Discipline d3 = new() { DisciplineName = "Geometry", DisciplineDiscription = "This is a branch of mathematics that studies spatial structures and relationships, as well as their generalizations.", Teacher = lecturer1 };

Course c1 = new() {CourseNumber = 1, CourseDisciplineList = new (){d1, d2, d3 }};
Course c2 = new() {CourseNumber = 2};
Course c3 = new() {CourseNumber = 3};
Course c4 = new() {CourseNumber = 4};


Student s1 = new() {FirstName = "Мария", LastName = "Иванова", MiddleName = "Ивановна", Age = 18, GroupNumber = "ТСО-105Б-24", StudentCourse = c1};
Student s2 = new() {FirstName = "Валентина", LastName = "Юдашкина", MiddleName = "Алексеевна", Age = 20, GroupNumber = "ТСО-105Б-24", StudentCourse = c1};
Student s3 = new() {FirstName = "Артур", LastName = "Пирожков", MiddleName = "Александрович", Age = 19, GroupNumber = "ТСО-105Б-24", StudentCourse = c1};    

//lecturer1.lecturerDiscipline.Add(discipline);
//PrintInfoList();

/*void PrintInfoList()
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
}*/



//в процессе разработки :)
 