using System;

namespace _4_function2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double health = 0, mana = 0;
            int maxHealth = 10, maxMana = 10;
            double maximumLength = 10, maximumPercentage = 100;
            
            while (true)
            {
                Console.WriteLine("Healthbar");
                DrawBar((int)health, maxHealth, ConsoleColor.Red, 1, '_');
                Console.WriteLine();
                Console.WriteLine("\nManabar");
                DrawBar((int)mana, maxMana, ConsoleColor.Blue, 4, '_');

                Console.SetCursorPosition(0, 6);

                Console.Write("Введите число на которое изменится жизнь в процентах: ");
                health = int.Parse(Console.ReadLine()) / maximumPercentage * maximumLength;
                Console.Write("Введите число на которое изменится мана в процентах: ");
                mana = int.Parse(Console.ReadLine()) / maximumPercentage * maximumLength;

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int value,  int MaxValue, ConsoleColor color, int position, char symbol = ' ', string sign = "#")
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for(int i = 0; i < value; i++)
            {
                bar += sign;
            }
            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for(int i = value; i < MaxValue; i++)
            {
                bar += symbol;
            }
            Console.Write(bar + ']');
        }
    }
}