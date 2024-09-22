using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int num = -1;
        int numberOfNumbers = 0;
        int largestNumber = 0;

        //Collecting all numbers from user
        while (num != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            num = int.Parse(input);
            numbers.Add(num);
            numberOfNumbers++;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        //Adding all the numbers in the list
        foreach (int number in numbers)
        {
            sum += number;
        }

        //finding the average 
        float average = ((float)sum) / (numberOfNumbers - 1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}