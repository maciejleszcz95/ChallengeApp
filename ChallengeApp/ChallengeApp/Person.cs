using System.Diagnostics;

namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, char gender, int age)
        {

            this.Name = name;
            this.Surname = surname;
            this.Gender = genderValidation(gender);
            this.Age = ageValidation(age);
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
        public int Age { get; private set; }

        private char genderValidation(char gender)
        {
            switch (gender)
            {
                case 'M': // Male
                case 'm':
                    return 'M';

                case 'F': // Female
                case 'f':
                    return 'F';

                default:
                    throw new Exception($"\"{gender}\" is wrong gender value!");
            }
        }
        private int ageValidation(int age)
        {
            if (age < 0)
            {
                throw new Exception($"Age value \"{age}\" cannot be negative!");
            }
                    
            return age;
        }
    }
}
