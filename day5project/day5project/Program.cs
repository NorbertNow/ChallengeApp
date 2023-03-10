int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

foreach (char letter in letters)
{
    if (letter == '0')
    {
        count[0]++;
    }
    else if (letter == '1')
    {
        count[1]++;
    }
    else if (letter == '2')
    {
        count[2]++;
    }
    else if (letter == '3')
    {
        count[3]++;
    }
    else if (letter == '4')
    {
        count[4]++;
    }
    else if (letter == '5')
    {
        count[5]++;
    }
    else if (letter == '6')
    {
        count[6]++;
    }
    else if (letter == '7')
    {
        count[7]++;
    }
    else if (letter == '8')
    {
        count[8]++;
    }
    else
    {
        count['9']++;
    }
}
var i = 0;
foreach (int digit in count)
{
    Console.WriteLine("cyfra '" + i + "' - " + digit + " razy");
    i++;
}