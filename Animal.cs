using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KESCHA
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public  int AgeDifference { get; set; }

        public Animal(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public Animal(
            string name,
            int userAge,
            int animalAge)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
        }
        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference betwen your and {Name}' s age is {AgeDifference}");
        }

        public void Greet(string userName)
        {
            if(userName == "")
            {
                userName = "Unkown Person";
            }
            Console.WriteLine($"Hello {userName}");
        }
        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference =  userAge - Age;
        }

        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }
        public void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }

        public void CompareAges(int userAge)
        {
            if(userAge > Age) 
            {
                Console.WriteLine("You are older!");
            }
            else if(userAge == Age)
            {
                Console.WriteLine("You are equal!");
            }
            else
            {
                Console.WriteLine("You are younger!");
            }
        }
        public void TellAbuotFriends(string userName, int userAge)
        {
            Console.WriteLine("Let me tell you about my friends.");

            string[] friendsName = new string[3];
            friendsName[0] = "Kasee";
            friendsName[1] = "Vasya";
            friendsName[2] = userName;
            int[] friendsAge = { 1, 2, userAge};
            
            for(int iterator = 0;  iterator < friendsName.Length; iterator++)
            {
                Console.WriteLine($"{friendsName[iterator]} is {friendsAge[iterator]} year old!");
            }
        }
    }
}
