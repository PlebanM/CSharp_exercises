using System;
using System.Collections.Generic;
using System.Text;

namespace PersonExercise
{
    class Employee : Person
    {
        public decimal Salary { get; set; }
        public string Profession { get; set; }

        public Room room;

        public Employee(string name, DateTime birthDate, decimal salary, string profession, Room roomNumber) : base(name, birthDate)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.room = roomNumber;
        }
        public override string ToString()
        {
            
            return base.ToString() + $"\nWypłata to: {Salary} w zawodzie {Profession}. Mieszka w pokoju {room.RoomNumber}";
        }
        
    }

    class Room
    {
        public int RoomNumber { get; }


        public Room(int roomNumber)
        {
            this.RoomNumber = roomNumber;
        }
    }
    class Start
    {
        static void Main(string[] args)
        {
            Person per1 = new Employee("Marcin", new DateTime(1985, 01, 21), 1600.66M, "Hydraulik", new Room(56));
            Console.WriteLine(per1);
        }
    }
}

