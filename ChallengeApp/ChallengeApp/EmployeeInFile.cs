namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

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

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"Grade value \"{grade}\" is out of range!");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (float.TryParse(line, out float number))
                        {
                            result.AddGrade(number);
                            line = reader.ReadLine();
                        }
                        else
                        {
                            throw new Exception($"Value \"{line}\" is not a float value!");
                        }
                    }
                }
            }

            return result;
        }
    }
}
