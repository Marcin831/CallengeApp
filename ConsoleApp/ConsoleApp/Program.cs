int number = 456673921;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int numberOf0 = 0;
int numberOf1 = 0;
int numberOf2 = 0;
int numberOf3 = 0;
int numberOf4 = 0;
int numberOf5 = 0;
int numberOf6 = 0;
int numberOf7 = 0;
int numberOf8 = 0;
int numberOf9 = 0;

foreach (var i in letters)
{
    if (i == '0')
    {
        numberOf0++;
    }
    else if (i == '1')
    {
        numberOf1++;
    }
    else if (i == '2')
    {
        numberOf2++;
    }
    else if (i == '3')
    {
        numberOf3++;
    }
    else if (i == '4')
    {
        numberOf4++;
    }
    else if (i == '5')
    {
        numberOf5++;
    }
    else if (i == '6')
    {
        numberOf6++;
    }
    else if (i == '7')
    {
        numberOf7++;
    }
    else if (i == '8')
    {
        numberOf8++;
    }
    else if (i == '9')
    {
        numberOf9++;
    }
}

Console.WriteLine("Wyniki dla liczby:" + number);
Console.WriteLine("0 = " + numberOf0);
Console.WriteLine("1 = " + numberOf1);
Console.WriteLine("2 = " + numberOf2);
Console.WriteLine("3 = " + numberOf3);
Console.WriteLine("4 = " + numberOf4);
Console.WriteLine("5 = " + numberOf5);
Console.WriteLine("6 = " + numberOf6);
Console.WriteLine("7 = " + numberOf7);
Console.WriteLine("8 = " + numberOf8);
Console.WriteLine("9 = " + numberOf9);