﻿
namespace ChallengeApp
{
    public class Manager : IEmployee
    {
        private List<float> grades = new List<float>();

        public Manager(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }

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

        public void AddGrade(double grade)
        {
            float gradeASFloat = (float)grade;
            this.AddGrade(gradeASFloat);
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
        public void AddGrade(string grade)
        {
           
                switch (grade)
                {
                    case "6":
                        AddGrade(100);
                        break;
                    case "-6":
                    case "6-":
                         AddGrade(95);
                         break;
                    case "+5":
                    case "5+":
                         AddGrade(85);
                         break;
                    case "5":
                        AddGrade(80);
                        break;
                    case "-5":
                    case "5-":
                        AddGrade(75);
                        break;
                    case "+4":
                    case "4+":
                        AddGrade(65);
                        break;
                    case "4":
                        AddGrade(60);
                        break;
                    case "-4":
                    case "4-":
                        AddGrade(55);
                        break;
                    case "+3":
                    case "3+":
                        AddGrade(45);
                        break;
                    case "3":
                        AddGrade(40);
                        break;
                    case "-3":
                    case "3-":
                        AddGrade(35);
                        break;
                    case "+2":
                    case "2+":
                        AddGrade(25);
                        break;
                    case "2":
                        AddGrade(20);
                        break;
                    case "-2":
                    case "2-":
                        AddGrade(15);
                        break;
                    case "+1":
                    case "1+":
                        AddGrade(5);
                        break;
                    case "1":
                        AddGrade(0);
                        break;
                    default:
                        throw new Exception("Wrong Number");
                }
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                throw new Exception("String in not float");
            }
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
                    statistics.AverageNumber = '6';
                    break;
                case var average when average >= 60:
                    statistics.AverageNumber = '5';
                    break;
                case var average when average >= 40:
                    statistics.AverageNumber = '4';
                    break;
                case var average when average >= 20:
                    statistics.AverageNumber = '3';
                    break;
                case var average when average >= 0:
                    statistics.AverageNumber = '2';
                    break;
                default:
                    statistics.AverageNumber = '1';
                    break;
            }

            return statistics;
        }
    }
}
