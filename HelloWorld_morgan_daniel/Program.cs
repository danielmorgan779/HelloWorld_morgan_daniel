using System;

namespace HelloWorld_morgan_daniel
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("We demand your first name!");        // This will write to the use asking for their first name
            string firstName = Console.ReadLine();      // This assigns what they typed in for their firstname to the firstName var
            Console.WriteLine("Now your last name?");       // this will ask for their last name
            string lastName = Console.ReadLine();       // and this assigns what they typed for their lastname to the firstName var

            // This displays their first and last name
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }
    }
}
