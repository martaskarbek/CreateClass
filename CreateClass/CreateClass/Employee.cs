using System;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        private int salary;
        private string profession;

        public Employee(string name, DateTime birthDate, string gender, Room room, int salary, string profession) : 
            base(name, birthDate, gender, room)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public int Salary
        {
            get => salary;
            set => salary = value;
        }

        public string Profession
        {
            get => profession;
            set => profession = value;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nProfession: {Profession}\nSalary: {Salary}\n";
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }
    }
}