using System;
Console.WriteLine("Welcome!!!! This program is a program that calculates the fibonacci sequence");
while (true)
{
    
    Console.Write("Enter value: ");
    string userInput = Console.ReadLine();
    int fibonacciEnd = Convert.ToInt32(userInput);

    int fibonacciStartOne = 0;
    int fibonacciStartTwo = 1;

    while (fibonacciStartOne <= fibonacciEnd)
    {
        Console.Write($"{fibonacciStartOne}, ");
        int nextFibonacci = fibonacciStartOne + fibonacciStartTwo;
        fibonacciStartOne = fibonacciStartTwo;
        fibonacciStartTwo = nextFibonacci;

    }
    Console.WriteLine();
    Console.WriteLine("Do you want to use the program again? 👉 y/n 👈");
    string answer = Console.ReadLine();

    if (answer.ToLower() != "y")
    {
        break;
    }

}