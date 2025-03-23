using LAB1_OOP;
//заполнение данными при старте программы 

//преподаватели
Lecturer lecturer1 = new() { FirstName = "Игорь", LastName = "Сидоров", MiddleName = "Николаевич", Age = 48, AcademicTitle = "Доцент", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer2 = new() { FirstName = "Ольга", LastName = "Иванова", MiddleName = "Петровна", Age = 45, AcademicTitle = "Профессор", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer3 = new() { FirstName = "Алексей", LastName = "Кузнецов", MiddleName = "Сергеевич", Age = 50, AcademicTitle = "Доцент", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer4 = new() { FirstName = "Татьяна", LastName = "Морозова", MiddleName = "Ивановна", Age = 42, AcademicTitle = "Старший преподаватель", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer5 = new() { FirstName = "Дмитрий", LastName = "Петров", MiddleName = "Александрович", Age = 55, AcademicTitle = "Профессор", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer6 = new() { FirstName = "Елена", LastName = "Смирнова", MiddleName = "Николаевна", Age = 47, AcademicTitle = "Доцент", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer7 = new() { FirstName = "Сергей", LastName = "Васильев", MiddleName = "Петрович", Age = 52, AcademicTitle = "Профессор", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer8 = new() { FirstName = "Наталья", LastName = "Федорова", MiddleName = "Сергеевна", Age = 40, AcademicTitle = "Старший преподаватель", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer9 = new() { FirstName = "Андрей", LastName = "Павлов", MiddleName = "Иванович", Age = 49, AcademicTitle = "Доцент", LecturerDiscipline = new List<Discipline>() };
Lecturer lecturer10 = new() { FirstName = "Марина", LastName = "Новикова", MiddleName = "Александровна", Age = 43, AcademicTitle = "Профессор", LecturerDiscipline = new List<Discipline>() };

//предметы
Discipline d1 = new() { DisciplineName = "Algebra", DisciplineDiscription = "A branch of mathematics that studies general techniques for manipulating quantities, regardless of their numerical values.", Teacher = lecturer1 };
Discipline d2 = new() { DisciplineName = "Geometry", DisciplineDiscription = "A branch of mathematics that studies shapes, sizes, and properties of figures.", Teacher = lecturer2 };
Discipline d3 = new() { DisciplineName = "Physics", DisciplineDiscription = "The natural science that studies matter, its motion, and behavior through space and time.", Teacher = lecturer3 };
Discipline d4 = new() { DisciplineName = "Chemistry", DisciplineDiscription = "The scientific study of the properties and behavior of matter.", Teacher = lecturer4 };
Discipline d5 = new() { DisciplineName = "Biology", DisciplineDiscription = "The study of living organisms and their interactions with each other and their environments.", Teacher = lecturer5 };
Discipline d6 = new() { DisciplineName = "History", DisciplineDiscription = "The study of past events, particularly in human affairs.", Teacher = lecturer6 };
Discipline d7 = new() { DisciplineName = "Literature", DisciplineDiscription = "The study of written works, especially those considered to have artistic or intellectual value.", Teacher = lecturer7 };
Discipline d8 = new() { DisciplineName = "Computer Science", DisciplineDiscription = "The study of computers and computational systems, including their principles, algorithms, and applications.", Teacher = lecturer8 };
Discipline d9 = new() { DisciplineName = "Philosophy", DisciplineDiscription = "The study of fundamental questions about existence, knowledge, values, reason, and more.", Teacher = lecturer9 };
Discipline d10 = new() { DisciplineName = "Economics", DisciplineDiscription = "The social science that studies the production, distribution, and consumption of goods and services.", Teacher = lecturer10 };

//добавляем список дисциплин преподавателю
lecturer1.LecturerDiscipline.Add(d1);
lecturer2.LecturerDiscipline.Add(d2);
lecturer3.LecturerDiscipline.Add(d3);
lecturer4.LecturerDiscipline.Add(d4);
lecturer5.LecturerDiscipline.Add(d5);
lecturer6.LecturerDiscipline.Add(d6);
lecturer7.LecturerDiscipline.Add(d7);
lecturer8.LecturerDiscipline.Add(d8);
lecturer9.LecturerDiscipline.Add(d9);
lecturer10.LecturerDiscipline.Add(d10);

//курсы
Course c1 = new() { CourseNumber = 1, CourseDisciplineList = new() { d1, d2, d3 } };
Course c2 = new() { CourseNumber = 2, CourseDisciplineList = new() { d4, d5, d6 } };
Course c3 = new() { CourseNumber = 3, CourseDisciplineList = new() { d7, d8, d9 } };
Course c4 = new() { CourseNumber = 4, CourseDisciplineList = new() { d10, d1, d2 } };

//студенты
Student s1 = new() { FirstName = "Мария", LastName = "Иванова", MiddleName = "Ивановна", Age = 18, GroupNumber = "ТСО-105Б-24", StudentCourse = c1 };
Student s2 = new() { FirstName = "Иван", LastName = "Петров", MiddleName = "Петрович", Age = 19, GroupNumber = "ТСО-205Б-23", StudentCourse = c2 };
Student s3 = new() { FirstName = "Анна", LastName = "Сидорова", MiddleName = "Сергеевна", Age = 20, GroupNumber = "ТСО-305Б-22", StudentCourse = c3 };
Student s4 = new() { FirstName = "Алексей", LastName = "Козлов", MiddleName = "Александрович", Age = 21, GroupNumber = "ТСО-405Б-21", StudentCourse = c4 };
Student s5 = new() { FirstName = "Елена", LastName = "Морозова", MiddleName = "Ивановна", Age = 18, GroupNumber = "ТСО-105Б-24", StudentCourse = c1 };
Student s6 = new() { FirstName = "Дмитрий", LastName = "Новиков", MiddleName = "Петрович", Age = 19, GroupNumber = "ТСО-205Б-23", StudentCourse = c2 };
Student s7 = new() { FirstName = "Ольга", LastName = "Волкова", MiddleName = "Сергеевна", Age = 20, GroupNumber = "ТСО-305Б-22", StudentCourse = c3 };
Student s8 = new() { FirstName = "Сергей", LastName = "Павлов", MiddleName = "Александрович", Age = 22, GroupNumber = "ТСО-405Б-21", StudentCourse = c4 };
Student s9 = new() { FirstName = "Татьяна", LastName = "Семенова", MiddleName = "Ивановна", Age = 18, GroupNumber = "ТСО-105Б-24", StudentCourse = c1 };
Student s10 = new() { FirstName = "Николай", LastName = "Федоров", MiddleName = "Петрович", Age = 19, GroupNumber = "ТСО-205Б-23", StudentCourse = c2 };

//add to lists
GlobalData.studentList.AddRange(new []{s1, s2, s3, s4, s5, s6, s7, s8, s9, s10});
GlobalData.lecturerList.AddRange(new []{lecturer1, lecturer2, lecturer3, lecturer4, lecturer5, lecturer6, lecturer7, lecturer8, lecturer9, lecturer10});
GlobalData.disciplines.AddRange(new []{d1, d2, d3, d4, d5, d6, d7, d8, d9, d10});
GlobalData.courseList.AddRange(new []{c1, c2, c3, c4});

//print lists
GlobalData.PrintInfoList();
Console.WriteLine();

Console.WriteLine("Welcome to some program. It will help you find any information about students, teachers, disciplines, and existing courses. We will be glad to help u :)");
Console.WriteLine("What data do you want to interact with?");
Console.WriteLine("1 - Student data" +
                  "\n2 - Lecturer data" +
                  "\n3 - Discipline data" +
                  "\n4 - Course data");
Console.WriteLine("Enter the appropriate number to navigate through the menu and execute the command:");
int input = int.Parse(Console.ReadLine());
switch (input)
{
 case 1:
     Console.WriteLine("Enter the appropriate number to navigate through the menu and execute the command:");
     Console.WriteLine("1 - add student " +
                       "\n2 - update student data" +
                       "\n3 - search student " +
                       "\n4 - delete student");
     int inputSt = int.Parse(Console.ReadLine());
     switch (inputSt)
     {
         case 1: 
             Student student = new Student();
             student.InputDataPerson(student);
             break;
         case 2:
             Console.WriteLine("Enter student id for update data:");
             Guid studentId = Guid.Parse(Console.ReadLine());
             Student studentToUpdate = new Student();
             studentToUpdate.UpdateStudent(studentId);
             break;
         case 3:
             Console.WriteLine("Enter student id for searching:");
             Guid studentIdToSearch = Guid.Parse(Console.ReadLine());
             Student studentToSearch = Student.SearchStudent(studentIdToSearch);
             break;
         case 4:
             Console.WriteLine("Enter student id for delete:");
             Guid studentIdToRemove = Guid.Parse(Console.ReadLine());
             Student studentToDelete = new Student();
             studentToDelete.RemoveStudent(studentIdToRemove);
             break;
     }

     break;
 case 2:
     Console.WriteLine("Enter the appropriate number to navigate through the menu and execute the command:");
     Console.WriteLine("1 - add lecturer " +
                       "\n2 - update lecturer data" +
                       "\n3 - search lecturer " +
                       "\n4 - delete lecturer");
     int inputLc = int.Parse(Console.ReadLine());
     switch (inputLc)
     {
         case 1: 
             Lecturer lecturer = new Lecturer();
             lecturer.InputDataPerson(lecturer);
             break;
         case 2:
             Console.WriteLine("Enter student id for update data:");
             Guid lecturerId = Guid.Parse(Console.ReadLine());
             Lecturer lecturerToUpdate = new Lecturer();
             lecturerToUpdate.UpdateLecturer(lecturerId);
             break;
         case 3:
             Console.WriteLine("Enter student id for searching:");
             Guid lecturerIdToSearch = Guid.Parse(Console.ReadLine());
             Lecturer lecturerToSearch = new Lecturer();
             lecturerToSearch.SearchLecturer(lecturerIdToSearch);
             break;
         case 4:
             Console.WriteLine("Enter student id for delete:");
             Guid lecturerIdToRemove = Guid.Parse(Console.ReadLine());
             Lecturer lecturerToDelete = new Lecturer();
             lecturerToDelete.RemoveLecturer(lecturerIdToRemove);
             break;
     }

     break;
 case 3:
     Console.WriteLine("Enter the appropriate number to navigate through the menu and execute the command:");
     Console.WriteLine("1 - add discipline " +
                       "\n2 - update discipline data" +
                       "\n3 - search discipline " +
                       "\n4 - delete discipline");
     int inputDs = int.Parse(Console.ReadLine());
     switch (inputDs)
     {
         case 1:
             Discipline discipline = new Discipline();
             discipline.InputDataDiscipline(discipline);
             break;
         case 2:
             Console.WriteLine("Enter student id for update data:");
             Guid disciplineId = Guid.Parse(Console.ReadLine());
             Discipline disciplineToUpdate = new Discipline();
             disciplineToUpdate.UpdateDiscipline(disciplineId);
             break;
         case 3:
             Console.WriteLine("Enter student id for searching:");
             Guid disciplineIdToSearch = Guid.Parse(Console.ReadLine());
             Discipline disciplineToSearch = new Discipline();
             disciplineToSearch.SearchDiscipline(disciplineIdToSearch);
             break;
         case 4:
             Console.WriteLine("Enter student id for delete:");
             Guid disciplineIdToRemove = Guid.Parse(Console.ReadLine());
             Discipline disciplineToDelete = new Discipline();
             disciplineToDelete.RemoveDiscipline(disciplineIdToRemove);
             break;
     }

     break;
 case 4:
     Console.WriteLine("Enter the appropriate number to navigate through the menu and execute the command:");
     Console.WriteLine("1 - add course " +
                       "\n2 - update course data" +
                       "\n3 - search course " +
                       "\n4 - delete course");
     int inputCr = int.Parse(Console.ReadLine());
     switch (inputCr)
     {
         case 1: 
             Course course = new Course();
             course.InputCourse(course);
             break;
         case 2:
             Console.WriteLine("Enter student id for update data:");
             Guid courseId = Guid.Parse(Console.ReadLine());
             Course courseToUpdate = new Course();
             courseToUpdate.UpdateCourse(courseId);
             break;
         case 3:
             Console.WriteLine("Enter student id for searching:");
             Guid courseIdToSearch = Guid.Parse(Console.ReadLine());
             Course courseToSearch = new Course();
             courseToSearch.SearchCourse(courseIdToSearch);
             break;
         case 4:
             Console.WriteLine("Enter student id for delete:");
             Guid courseIdToRemove = Guid.Parse(Console.ReadLine());
             Course courseToDelete = new Course();
             courseToDelete.RemoveCourse(courseIdToRemove);
             break;
     }

     break;
}


 