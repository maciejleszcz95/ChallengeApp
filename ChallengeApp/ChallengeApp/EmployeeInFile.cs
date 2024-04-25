using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, char gender, int age)
            : base(name, surname, gender, age)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception($"Grade value \"{grade}\" is out of range!");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics()
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue
            };

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    int count = 0;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (float.TryParse(line, out float number))
                        {
                            result.Max = Math.Max(result.Max, number);
                            result.Min = Math.Min(result.Min, number);
                            result.Average += number;
                            count++;
                            line = reader.ReadLine();
                        }
                        else
                        {
                            throw new Exception($"Value \"{line}\" is not a float value!");
                        }
                    }
                    result.Average /= count;
                }
            }

            switch (result.Average)
            {
                case var average when average >= 80:
                    result.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    result.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    result.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    result.AverageLetter = 'D';
                    break;
                default:
                    result.AverageLetter = 'E';
                    break;
            }

            return result;
        }
    }
}
