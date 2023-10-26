using challengeApp;

namespace ChallengeApp.Tests
{

    public class Tests
    {
       

        [Test]
        public void CheckSumOperation()
        {
            //arerange
            var employee = new Employee("Sebastian", "B¹k");
            employee.AddScore(1);
            //act

            var result = employee.Result;

            //assert
            
        }
    }
}