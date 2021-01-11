using System;

namespace CreateClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee("Hugh", DateTime.Now, Gender.Male.ToString(), new Room(123), 
                234455, "actor");
            employee.Room.RoomNumber = 2;
            Console.WriteLine("First instance of employee:\n");
            Console.WriteLine(employee.ToString());
            Console.WriteLine("\nInstance of cloned employee:\n");
            var clone = employee.Clone();
            Console.WriteLine(clone.ToString());
        }
    }
}