using System;

namespace Route._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment2
            #region Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter Your Number");
            //int myNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Your number is:  = {myNum}");
            #endregion

            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int a = 5; // Declare and initialize variable a
            //int b = a;  // Assign the value of a to b

            //Console.WriteLine("Before modifying:");
            //Console.WriteLine($"a ={a}"); // Output: a = 5
            //Console.WriteLine($"b ={b}"); // Output: b = 5

            //b = 10; // Modify the value of b

            //Console.WriteLine("After modifying:");
            //Console.WriteLine($"a ={a}"); // Output: a = 5
            //Console.WriteLine($"b ={b}"); // Output: b = 10
            #endregion

            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            // Create a new Person object
            Person person1 = new Person();
            person1.Name = "Sameh";
            // Assign person1 to person2
            Person person2 = person1;
            Console.WriteLine("Before Modifying:");
            Console.WriteLine($"person1.Name:={person1.Name}"); //Output: person1.Name = Sameh
            Console.WriteLine($"person2.Name:={person2.Name}"); //Output: person2.Name = Sameh

            person2.Name = "Mohamed";
            
            Console.WriteLine("After Modifying:");
            Console.WriteLine($"person1.Name:={person1.Name}");//Output: person1.Name = Mohamed
            Console.WriteLine($"person2.Name:={person2.Name}");//Output: person1.Name = Mohamed
            #endregion
            #endregion
        }
    }
}
