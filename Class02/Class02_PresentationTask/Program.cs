using Class02_PresentationTask.Entities;

List<int> gradesForStudentOne = new List<int>() { 3, 5, 4, 2 };
List<int> gradesForStudentTwo = new List<int>() { 2, 5, 4, 2 };

Student student1 = new Student("Antonio", "Sirius", 3, "antonio", gradesForStudentOne);
Student student2 = new Student("Kostadin", "Petkov", 2, "kostadin", gradesForStudentTwo);

Console.WriteLine("Grades for student1:");
student1.PrintUser();

Console.WriteLine("Grades for student2:");
student2.PrintUser();

Teacher teacher1 = new Teacher("Martin" , "martin" , 1 , "martin123" , "C#");
Teacher teacher2 = new Teacher("Risto", "risto", 4, "risto123", "MVC");

Console.WriteLine("Teacher1 Info:");
teacher1.PrintUser();

Console.WriteLine("Teacher2 Info:");
teacher2.PrintUser();
