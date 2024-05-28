
using KESCHA;

Animal kescha = new Animal(name: "Kescha", age: 3);

Console.Write("Enter your name: ");
string userName = Console.ReadLine();
kescha.Greet(userName);

Console.Write("Enter you age: ");
string ageAsString = Console.ReadLine();

Console.WriteLine("Converting....");
int userAge = Convert.ToInt32(ageAsString);
Console.WriteLine($"Succesfully converted! {userAge}");

kescha.CalculateAgeDifferenceWithNoReturn(userAge);
kescha.PrintAgeDifference();
kescha.CompareAges(userAge);
kescha.TellAbuotFriends(userName, userAge);
