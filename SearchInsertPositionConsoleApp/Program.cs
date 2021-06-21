using System;
using SearchInsertPositionDomain.Models;

namespace SearchInsertPositionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 1, 3, 5, 6 };
            var target = 5;
            var result = SuperArray.SearchInsertPosition(numbers, target);

            Console.WriteLine($"The insert index position for the number {target} is: {result}");
        }
    }
}
