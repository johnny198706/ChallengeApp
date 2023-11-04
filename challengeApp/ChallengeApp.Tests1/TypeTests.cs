

using challengeApp;

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
            var employee1 = GetEmployee("Rafał", "Stefański", 32);
            var employee2 = GetEmployee("Nadia", "Nowakowska", 26);

            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }


    }
}
