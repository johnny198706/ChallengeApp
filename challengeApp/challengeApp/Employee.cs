
namespace challengeApp
{
     class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }


        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }


    }
}
