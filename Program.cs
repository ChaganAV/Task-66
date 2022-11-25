int numBegin = InputInt("Введите начальное значение ");
int numEnd = InputInt("Введите конечное значение ");

int sumNumbers = 0;
sumNumbers = SumNumber(numBegin, numEnd);

Console.WriteLine($"{sumNumbers}");

int SumNumber(int min, int max)
{
    int sum;
    if (max==min)
        return min;
    else
    {
        max--;
        Console.WriteLine($"{max}");
        sum = max + SumNumber(min, max);
        Console.WriteLine($"sum = {sum}");
        return sum;
    }   
}


int InputInt(string message)
{
    Console.WriteLine(message);
    Console.Write("> ");
    return Convert.ToInt32(Console.ReadLine());
}
