using System;
using AutomatedTestLibrary;

namespace AutomatedTestingConsole
{
    public class Program
    {
        static void Main(string[] args)
        {

            var functions = new Functions();


            var answer = functions.Add1(3);//should return 4

            Console.WriteLine($"Answer is: {answer}");


        }
    }
}
