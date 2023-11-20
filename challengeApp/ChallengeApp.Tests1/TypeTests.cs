

using ChallengeApp;

namespace ChallengeApp.Tests1
{
    public class TypeTests
    {
        [Test]
        public void TestValueType()
        {
            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TestValueTypeTwo()
        {
            float number1 = 4.98f;
            float number2 = 4.98f;

            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void TestReferenceType()
        {
            var employee1 = GetEmployee("Rafał", "Stefański",'M', 32);
            var employee2 = GetEmployee("Nadia", "Nowakowska",'M', 26);

            Assert.AreNotEqual(employee1, employee2);
        }

        private EmployeeInMemory GetEmployee(string name, string surname,char sex, int age)
        {
            return new EmployeeInMemory(name, surname,sex, age);
        }


    }
}
