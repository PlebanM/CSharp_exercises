using System;

namespace PersonExercise
{
    class Person
    {

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
        public enum Genders { male, female }

        private string WriteGender()
        {
            if (Name.EndsWith("a"))
            {
                return $"{Genders.female}";
            }
            else
            {
                return $"{Genders.male}";
            }
        }
        public override string ToString()
        {
            return $"{Name} urodzony: {BirthDate.Year} jako {WriteGender()}";
        }

    }
    
}
