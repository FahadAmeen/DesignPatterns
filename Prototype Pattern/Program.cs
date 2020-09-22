using System;

namespace Prototype_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1=new Person();
            person1.Age = 42;
            person1.BirthDate = Convert.ToDateTime("1977-01-01");
            person1.Name = "Jack Daniels";
            person1.IdInformation = new IdInformation(666);

            // Perform a shallow copy of person1 and assign it to person2.
            Person person2 = person1.ShallowCopy();
            // Make a deep copy of person1 and assign it to person3.
            Person person3 = person1.DeepCopy();

            // Display values of person1, person2 and person3.
            Console.WriteLine("Original values of person1, person2, person3:");
            Console.WriteLine("   person1 instance values: ");
            DisplayValues(person1);
            Console.WriteLine("   person2 instance values:");
            DisplayValues(person2);
            Console.WriteLine("   person3 instance values:");
            DisplayValues(person3);

            // Change the value of person1 properties and display the values of person1,
            // person2 and person3.
            person1.Age = 32;
            person1.BirthDate = Convert.ToDateTime("1900-01-01");
            person1.Name = "Frank";
            person1.IdInformation.IdNumber = 7878;
            Console.WriteLine("\nValues of person1, person2 and person3 after changes to person1:");
            Console.WriteLine("   person1 instance values: ");
            DisplayValues(person1);
            Console.WriteLine("   person2 instance values (reference values have changed):");
            DisplayValues(person2);
            Console.WriteLine("   person3 instance values (everything was kept the same):");
            DisplayValues(person3);

        }
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInformation.IdNumber);
        }
    }
}
