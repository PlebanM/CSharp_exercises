using System;
using System.Collections.Generic;
using System.Text;

namespace PersonExercise
{
    class Employee : Person, ICloneable
    {
        public decimal Salary { get; set; }
        public string Profession { get; set; }

        public Room room;

        public Employee(string name, DateTime birthDate, decimal salary, string profession) : base(name, birthDate)
        {
            this.Salary = salary;
            this.Profession = profession;
         
        }
        public override string ToString()
        {
            
            return base.ToString() + $"\nWypłata to: {Salary} w zawodzie {Profession}. Mieszka w pokoju {room.RoomNumber}";
        }

        public object Clone2()
        {
            return this.MemberwiseClone();
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.room = new Room(room.RoomNumber);

            return newEmployee;
        }
    }

    class Room
    {
        public int RoomNumber { get; set; }


        public Room(int roomNumber)
        {
            this.RoomNumber = roomNumber;
        }
    }
    class Start
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000M, "léhűtő");
            Kovacs.room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}

