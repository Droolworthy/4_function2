using System;

namespace _4_function2
{
internal class Program
    {
        static void Main(string[] args)
        {
            double health = 0;
            double mana = 0;
            int maxHealth = 10;
            int maxMana = 10;
            double maximumLength = 10;
            double maximumPercentage = 100;
            string userInput;
            string stopProgram = "exit";
            bool canExitApp = true;

            while (canExitApp)
            {
                ShowBars(health, mana, maxHealth, maxMana);
               
                Console.SetCursorPosition(0, 6);

                Console.Write("Введите число на которое изменится жизнь в процентах: ");
                health = int.Parse(Console.ReadLine()) / maximumPercentage * maximumLength;
                Console.Write("Введите число на которое изменится мана в процентах: ");
                mana = int.Parse(Console.ReadLine()) / maximumPercentage * maximumLength;
                
                Console.Clear();

                ShowBars(health, mana, maxHealth, maxMana);

                Console.WriteLine($"\n\nДля выхода введите - {stopProgram}");
                Console.WriteLine("\nЧтобы заполнить бары ещё раз нажмите любую клавишу...");
                Console.Write("\nВвод: ");
                
                userInput = Console.ReadLine();

                if(userInput == stopProgram)
                {
                    canExitApp = false;
                }
                else
                {
                    Console.Clear();
                }
            }            
        }

        static void ShowBars(double health, double mana, int maxHealth, int maxMana)
        {
            Console.WriteLine("Healthbar");
            DrawBar((int)health, maxHealth, ConsoleColor.Red, 1, '_');
            Console.WriteLine();
            Console.WriteLine("\nManabar");
            DrawBar((int)mana, maxMana, ConsoleColor.Blue, 4, '_');
        }
        
        static void DrawBar(int value,  int maxValue, ConsoleColor color, int position, char symbol = ' ', string sign = "#")
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

            for(int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }
            Console.Write(bar + ']');
        }
    }
}
