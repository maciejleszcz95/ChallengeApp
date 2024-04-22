namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Employee()
        {

        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Error: Grade value \"{grade}\" is out of range!");
            }
        }
        public void AddGrade(int grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(string grade)
        {
            if (char.TryParse(grade, out char resultChar) && char.IsLetter(resultChar))
            {
                switch (resultChar)
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
                        Console.WriteLine($"Error: \"{grade}\" is wrong grade letter!");
                        break;
                }
            }
            else if (float.TryParse(grade, out float resultFloat))
            {
                this.AddGrade(resultFloat);
            }
            else
            {
                Console.WriteLine($"Error: Value \"{grade}\" is not a proper value!");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

    }
}
