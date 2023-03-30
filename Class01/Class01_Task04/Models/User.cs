namespace Class01_Task04.Models
{
    public class User
    {
        public User(string name , int id)
        {
            Name = name;
            Id = id;
        }
        public string Name { get; set; }

        public int Id { get; set; }
    }
}
