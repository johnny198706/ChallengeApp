
namespace challengeApp 

{

    public class Employee 
    {
        public List<int> score = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return score.Sum();
            }
        }
        

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }

}
