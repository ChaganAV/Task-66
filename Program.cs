int numBegin = InputInt("Введите начальное значение ");
int numEnd = InputInt("Введите конечное значение ");

int sumNumbers = SumNumber(numBegin, numEnd);

Console.WriteLine($"M={numBegin}; N={numEnd} -> {sumNumbers}");

int SumNumber(int min, int max)
{
    if (max==min)
        return min;
    else
    {
        return max + SumNumber(min, max - 1);
    }   
}


int InputInt(string message)
{
    Console.WriteLine(message);
    Console.Write("> ");
    return Convert.ToInt32(Console.ReadLine());
}
