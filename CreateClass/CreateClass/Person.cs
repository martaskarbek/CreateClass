using System;

namespace CreateClass
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private string gender;
        private Room room;
        
        public Person(string name, DateTime birthDate, string gender, Room room)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            Room = room;
        }

        public Room Room
        {
            get => room;
            set => room = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nBirth Date: {BirthDate}\nGender: {Gender}\nClass number: {Room.RoomNumber}";
        }
    }
}