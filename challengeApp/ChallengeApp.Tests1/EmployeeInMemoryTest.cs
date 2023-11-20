using ChallengeApp;

namespace ChallengeApp.Tests1
{
    public class EmployeeInMemoryTest
    {
      

        [Test]
        public void WhatIsMaxGrade()
        {
            var employee = new EmployeeInMemory("Rafa³", "Stefañski",'M', 32);

            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Max, Is.EqualTo(7));
        }

        [Test]
        public void WhatIsMinGrade()
        {
            var employee = new EmployeeInMemory("Rafa³", "Stefañski", 'M', 32);

            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Min, Is.EqualTo(3));
        }

        [Test]
        public void WhatIsTheAverageGrade()
        {
            var employee = new EmployeeInMemory("Rafa³", "Stefañski", 'M', 32);

            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.That(statistics.Average, Is.EqualTo(5.6f));
        }


        [Test]
        public void WhatIsAverageLetter()
        {
            var employee = new EmployeeInMemory("Rafa³", "Stefañski", 'M', 32);

            employee.AddGrade(7);
            employee.AddGrade(30);
            employee.AddGrade(60);
            employee.AddGrade(7);
            employee.AddGrade('a');

            var statistics = employee.GetStatistics();

            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
    }  
}