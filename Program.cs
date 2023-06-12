string baseResult = "";
Console.Write("Enter Number:");
int number = int.Parse(Console.ReadLine()!);

Console.Write("Enter You Base:");
int toBase = int.Parse(Console.ReadLine()!);

if (!CheckValidBase(toBase))
{
    Console.WriteLine("Invalid Base");
}
else
{
    while (number != 0)
    {
        int remain = number % toBase;
        if (remain < 10)
            baseResult += remain;
        else
        {
            if (remain == 10)
            {
                baseResult += "A";
            }
            else if (remain == 11)
            {
                baseResult += "B";
            }
            else if (remain == 12)
            {
                baseResult += "C";
            }
            else if (remain == 13)
            {
                baseResult += "D";
            }
            else if (remain == 14)
            {
                baseResult += "E";
            }
            else if (remain == 15)
            {
                baseResult += "F";
            }
        }
        number /= toBase;
    }

    for (int i = baseResult.Length - 1; i >= 0; i--)
    {
        Console.Write(baseResult[i]);
    }
}
bool CheckValidBase(int toBase)
{
    if (toBase == 2 || toBase == 8 || toBase == 10 || toBase == 16)
        return true;
    return false;
}