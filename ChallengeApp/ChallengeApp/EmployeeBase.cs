namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname, char gender, int age)
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

        public void AddGrade(int grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100f);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80f);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60f);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40f);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20f);
                    break;
                default:
                    throw new Exception($"\"{grade}\" is wrong grade letter!");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resultFloat))
            {
                this.AddGrade(resultFloat);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new Exception($"Value \"{grade}\" is not a char letter or float value!");
            }
        }
        public abstract void AddGrade(float grade);

        public abstract Statistics GetStatistics();
    }
}
