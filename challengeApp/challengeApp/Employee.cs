
using ChallengeApp;


namespace challengeApp

{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname,char sex, int age)
            :base(name,surname,sex,age)
        {
           
        }

        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }

        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                switch (charResult)
                {
                    case 'A':
                    case 'a':
                        AddGrade(100);
                        break;
                    case 'B':
                    case 'b':
                        AddGrade(80);
                        break;
                    case 'C':
                    case 'c':
                        AddGrade(60);
                        break;
                    case 'D':
                    case 'd':
                        AddGrade(40);
                        break;
                    case 'E':
                    case 'e':
                        AddGrade(20);
                        break;
                    default:
                        throw new Exception("Wrong Lettter");
                }
            }
            else
            {
                throw new Exception("String in not float");
            }

        }

        public void AddGrade(double grade)
        {
           float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeASFloat = grade;
            this.AddGrade(gradeASFloat);
        }
     
        public void AddGrade(long grade)
        {
            float gradeASFloat = grade;
            this.AddGrade(gradeASFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            
            return statistics;
        }        
    }

}
