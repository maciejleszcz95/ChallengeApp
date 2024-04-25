namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        char Gender { get;  }
        int Age { get; }

        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
