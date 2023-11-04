using challengeApp;

namespace ChallengeApp.Tests1
{
    public class Tests
    {
      

        [Test]
        public void WhatIsMaxGrade()
        {
            var employee = new Employee("Rafa³", "Stefañski", 32);

            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(7,statistics.Max);
        }

        [Test]
        public void WhatIsMinGrade()
        {
            var employee = new Employee("Rafa³", "Stefañski", 32);

            employee.AddGrade(7);
            employee.AddGrade(-3);
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(-3,statistics.Min);
        }

        [Test]
        public void WhatIsTheAverageGrade()
        {
            var employee = new Employee("Rafa³", "Stefañski", 32);

            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();  

            Assert.AreEqual(5.6f ,statistics.Average);   
        }
    }








   

  
}