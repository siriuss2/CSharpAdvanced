using Class02_PresentationTask.Entities.Interfaces;

namespace Class02_PresentationTask.Entities
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(int id , string name , string userName , string password)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
        }

        public abstract void PrintUser();
    }
}
