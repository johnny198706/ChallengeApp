using ChallengeApp;

namespace ChallengeApp.Tests1
{
    public class EmployeeInFileTest
    {
        [Test]
        public void WhatIsMaxGradeEmployeeInFile()
        {
            var employee = new EmployeeInFile("Rafał", "Stefański", 'M', 32);

            employee.AddGrade(70);
            employee.AddGrade(30);
            employee.AddGrade(60);
            employee.AddGrade(70);
            employee.AddGrade(100);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Max, Is.EqualTo(7));
        }

        [Test]
        public void WhatIsMinGradeEmployeeInFile()
        {
            var employee = new EmployeeInFile("Rafał", "Stefański", 'M', 32);

            employee.AddGrade(70);
            employee.AddGrade(30);
            employee.AddGrade(60);
            employee.AddGrade(70);
            employee.AddGrade(50);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Min, Is.EqualTo(3));
        }

        [Test]
        public void WhatIsTheAverageGradeEmployeeInFile()
        {
            var employee = new EmployeeInFile("Rafał", "Stefański", 'M', 32);

            employee.AddGrade(70);
            employee.AddGrade(30);
            employee.AddGrade(60);
            employee.AddGrade(70);
            employee.AddGrade(50);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Average, Is.EqualTo(5.6f));
        }


        [Test]
        public void WhatIsAverageLetterEmployeeInFile()
        {
            var employee = new EmployeeInFile("Rafał", "Stefański", 'M', 32);

            employee.AddGrade(70);
            employee.AddGrade(30);
            employee.AddGrade(60);
            employee.AddGrade(70);
            employee.AddGrade('a');

            var statistics = employee.GetStatistics();

            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }

    }
}
