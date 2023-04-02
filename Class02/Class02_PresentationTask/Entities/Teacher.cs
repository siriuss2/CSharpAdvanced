using Class02_PresentationTask.Entities.Interfaces;

namespace Class02_PresentationTask.Entities
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher(string name, string userName, int id, string password, string subject) 
                    : base(id , name , userName , password)
        {
            Subject = subject;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Name: {Name} | Username: {UserName} | Id: {Id} | Password: {Password} | Subject: {Subject}");
        }
    }
}
