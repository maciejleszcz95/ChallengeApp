namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

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
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100f);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(95f);
                    break;
                case "+5":
                case "5+":
                    this.AddGrade(85f);
                    break;
                case "5":
                    this.AddGrade(80f);
                    break;
                case "-5":
                case "5-":
                    this.AddGrade(75f);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade(65f);
                    break;
                case "4":
                    this.AddGrade(60f);
                    break;
                case "-4":
                case "4-":
                    this.AddGrade(55f);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade(45f);
                    break;
                case "3":
                    this.AddGrade(40f);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade(35f);
                    break;
                case "2+":
                case "+2":
                    this.AddGrade(25f);
                    break;
                case "2":
                    this.AddGrade(20f);
                    break;
                case "-2":
                case "2-":
                    this.AddGrade(15f);
                    break;
                case "1+":
                case "+1":
                    this.AddGrade(5f);
                    break;
                case "1":
                    this.AddGrade(0f);
                    break;
                default:
                    throw new Exception($"\"{grade}\" is wrong grade!");
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
