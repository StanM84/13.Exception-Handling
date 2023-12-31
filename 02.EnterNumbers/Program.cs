﻿static int ReadNum (int start, int end)
{
    int num = int.Parse(Console.ReadLine());

    if (num <= start || num >= end)
    {
        throw new ArgumentException();
    }
    return num;
}

List<int> numbers = new List<int>();
int prevNum = 1;

while (numbers.Count < 10)
{
    try
    {


    int number = ReadNum (prevNum, 100);
    numbers.Add(number);
    prevNum = number;

    }
    catch (ArgumentException)
    {
        Console.WriteLine($"Your number is not in range {prevNum} - 100!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }
}
Console.WriteLine(string.Join(", ",numbers));