namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private List<float> grades = new List<float>(); 

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, char sex, int age)
            : base(name, surname, sex, age)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddGrade(string grade)
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

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(long grade)
        {          
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override Statistics GetStatistics()
        {
           var result = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.Average = 0;
                        result.Max = float.MinValue;
                        result.Min = float.MaxValue;
                        foreach (var grade in this.grades)
                        {
                            result.Max = Math.Max(result.Max, grade);
                            result.Min = Math.Min(result.Min, grade);
                            result.Average += grade;
                        }

                        result.Average /= this.grades.Count;

                        switch (result.Average)
                        {
                            case var average when average >= 80:
                                result.AverageLetter = 'A';
                                break;
                            case var average when average >= 60:
                                result.AverageLetter = 'B';
                                break;
                            case var average when average >= 40:
                                result.AverageLetter = 'C';
                                break;
                            case var average when average >= 20:
                                result.AverageLetter = 'D';
                                break;
                            default:
                                result.AverageLetter = 'E';
                                break;
                        }
                    }
                }
            }
           return result;
        }
    }
}
