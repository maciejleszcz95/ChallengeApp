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
        public void AddGrade(long grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(float[] grade)
        {
            foreach (float gradeItem in grade)
            {
                this.AddGrade(gradeItem);
            }
        }
        public void AddGrade(string[] grade)
        {
            foreach (string gradeItem in grade)
            {
                this.AddGrade(gradeItem);
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"Error: Value \"{grade}\" is not a float value!");
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

            return statistics;
        }
    }
}
