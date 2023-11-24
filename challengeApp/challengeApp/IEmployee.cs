
using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        int Age { get; }

        char Sex { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        public event GradeAddedDelegate GradeAdded;

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(long grade);

        Statistics GetStatistics();
    }
}
