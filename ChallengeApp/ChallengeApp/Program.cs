int number = 4566;
string numberString = number.ToString();
char[] letters = numberString.ToCharArray();
Console.WriteLine("Wybrana liczba to: " + number);

List<int> counters = new List<int>(10);


for (int i = 0; i < 10; i++)
{
    counters.Add(0);
}

foreach (char letter in letters)
{
    if (Char.IsDigit(letter))
    {
        int digit = letter - '0';
        counters[digit]++;
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " ==> " + counters[i]);
}