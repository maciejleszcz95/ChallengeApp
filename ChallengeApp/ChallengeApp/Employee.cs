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
                throw new Exception($"Grade value \"{grade}\" is out of range!");
            }
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
        public Statistics GetStatistics()
        {
            var statistics = new Statistics
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue
            };

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
