using System;
using RPS.Models;

namespace RPS
{
    public class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            TypeLine("Welcome to the Rock, Paper, Scissors game!");
            TypeLine("Let's decide an amount of rounds to play");
            TypeLine("How many rounds won will end the match? Please enter a whole number");
            Game newGame = new Game();
            newGame.WinCount = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            TypeLine("Okay, lets play! First to " + newGame.WinCount + " wins!");
            newGame.GamePlay();
        }


        public static void TypeLine(string input)
        {
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i]);
            System.Threading.Thread.Sleep(25);
        }
        Console.Write(Environment.NewLine);
        Console.Write(Environment.NewLine);
        }
    }
}