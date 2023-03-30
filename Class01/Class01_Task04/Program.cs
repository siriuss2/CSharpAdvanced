#region GetMessage() method
using Class01_Task04.Models;

string[] messages = new string[4] { "Hello dear student!", "Goodbye dear student!", "Have a nice day!", "Nice to meet you!" };
Console.WriteLine("Enter number");
int userInput = int.Parse(Console.ReadLine());

string GetMessage(int userInput, string[] messages)
{
    return messages[userInput];
}

Console.WriteLine(GetMessage(userInput, messages));

#endregion

Console.WriteLine("=====================================");

#region Average() method

List<int> numbers = new List<int>();
numbers.Add(2);
numbers.Add(2);
numbers.Add(2);
numbers.Add(2);
numbers.Add(2);


double Average(List<int> numbers)
{
    return numbers.Average();
}

Console.WriteLine(Average(numbers));

#endregion

Console.WriteLine("=====================================");

#region Sum() method

List<int> sumOfNumbers = new List<int>();
sumOfNumbers.Add(2);
sumOfNumbers.Add(1);
sumOfNumbers.Add(2);
sumOfNumbers.Add(5);

int Sum(List<int> sumOfNumbers)
{
    return sumOfNumbers.Sum();
}

Console.WriteLine(Sum(sumOfNumbers));

#endregion

Console.WriteLine("=====================================");

#region GetUserByName() method 

List<User> users = new List<User>()
{
    new User ("Antonio" , 1),
    new User ("Tosho" , 2),
    new User("Marija" , 3),
    new User("Monika" , 4),
};

User GetUserByName(List<User> users, string name)
{
    return users.Where(user => user.Name.ToLower() == name.ToLower()).FirstOrDefault();
}

User user1 = GetUserByName(users, "Antonio");
Console.WriteLine(user1.Name);

Console.WriteLine(GetUserByName(users , "Tosho").Name);



#endregion
