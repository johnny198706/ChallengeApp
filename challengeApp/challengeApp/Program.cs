

using System.Diagnostics.CodeAnalysis;

int number = 435007657;
string numberInStrin = number.ToString();
char[] letters = number.ToString().ToArray();




string[] numbers = new string[10];
numbers[0] = ("0=>");
numbers[1] = ("1=>");
numbers[2] = ("2=>");
numbers[3] = ("3=>");
numbers[4] = ("4=>");
numbers[5] = ("5=>");
numbers[6] = ("6=>");
numbers[7] = ("7=>");
numbers[8] = ("8=>");
numbers[9] = ("9=>");



int counter = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;




foreach (char letter in letters)
{
    if(letter == '0')
    {
        counter++;

    }
    else if(letter == '1')
    {
        counter1++;
    
    }
    else if (letter == '2')
    {
        counter2++;

    }
    else if(letter == '3') 
    {
        counter3++;
    
    }
    else if(letter == '4')
    {
        counter4++;
   
    }
    else if(letter == '5')
    {
        counter5++;
 
    }
    else if(letter == '6')
    {
        counter6++;

    }
    else if(letter == '7')
    {
        counter7++;

    }
    else if(letter == '8')
    {
        counter8++;

    }
    else if(letter == '9')
    {
        counter9++;
  
    }
}


Console.WriteLine(numbers[0] + counter);
Console.WriteLine(numbers[1] + counter1);
Console.WriteLine(numbers[2] + counter2);
Console.WriteLine(numbers[3] + counter3);
Console.WriteLine(numbers[4] + counter4);
Console.WriteLine(numbers[5] + counter5);
Console.WriteLine(numbers[6] + counter6);
Console.WriteLine(numbers[7] + counter7);
Console.WriteLine(numbers[8] + counter8);
Console.WriteLine(numbers[9] + counter9);

