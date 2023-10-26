using challengeApp;

namespace ChallengeApp.Tests1
{
    public class Tests
    {
      

        [Test]
        public void WhenEmployeeFiveSetScore_ShouldCorrectResult()
        {
            // arrange
           var employee2 = new Employee("Mateusz", "Zieliñski", 27);
            employee2.AddScore(10);
            employee2.AddScore(10);
            employee2.AddScore(1);
            employee2.AddScore(1);
            employee2.AddScore(1);

            // act
            var result = employee2.Result;
           // assert
           Assert.AreEqual(23, result);

           
        }
       
    }
    public class Test
    {


        [Test]
        public void WhenEmployeeFiveSetPoint_ShouldCorrectResult()
        {
            // arrange
            var employee1 = new Employee("Rafa³", "Stefañski", 32);
            employee1.AddScore(10);
            employee1.AddScore(10);
            employee1.AddScore(-6);
            employee1.AddScore(-10);
            employee1.AddScore(-8);

            // act
            var result = employee1.Result;
            // assert
            Assert.AreEqual(-4, result);


        }

    }
}