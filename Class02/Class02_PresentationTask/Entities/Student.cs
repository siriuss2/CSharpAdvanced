using Class02_PresentationTask.Entities.Interfaces;

namespace Class02_PresentationTask.Entities
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student(string name , string userName , int id , string password , List<int> grades) 
                    : base(id , name , userName , password)
        {
            Grades = grades;
        }

        public override void PrintUser()
        {   
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }

        }
    }

}
