using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class MathOperations
    {
        public static void Addition()
        {

            Random random = new Random();
            var score = 0;

            for (int i = 0; i <= 5; i++)
            {
                var num1 = random.Next(1, 10);
                var num2 = random.Next(1, 10);
                Console.WriteLine($"{num1} + {num2} = ");
                var result = int.Parse(Console.ReadLine());


                if (result == num1 + num2)
                {
                    Console.WriteLine("You're correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You're wrong");
                }
            }
            Console.WriteLine($"You scored {score} points");

            Program.AddGame($"{DateTime.Now} - Addition: Score = {score}");

            Console.WriteLine("Press any key to play again");
            Console.ReadLine();

            
        }
        public static void Subtraction()
        {
            Random random = new Random();
            var score = 0;

            for (int i = 0; i <= 5; i++)
            {
                var num1 = random.Next(1, 10);
                var num2 = random.Next(1, 10);
                Console.WriteLine($"{num1} - {num2} = ");
                var result = int.Parse(Console.ReadLine());


                if (result == num1 - num2)
                {
                    Console.WriteLine("You're correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You're wrong");
                }
            }
            Console.WriteLine($"You scored {score} points");

            Program.AddGame($"{DateTime.Now} - Subtraction: Score = {score}");

            Console.WriteLine("Press any key to to play again");
            Console.ReadLine();

        }
        public static void Multiplication()
        {
            Random random = new Random();
            var score = 0;

            for (int i = 0; i <= 5; i++)
            {
                var num1 = random.Next(1, 10);
                var num2 = random.Next(1, 10);
                Console.WriteLine($"{num1} * {num2} = ");
                var result = int.Parse(Console.ReadLine());


                if (result == num1 * num2)
                {
                    Console.WriteLine("You're correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You're wrong");
                }
            }
            Console.WriteLine($"You scored {score} points");

            Program.AddGame($"{DateTime.Now} - Multiplication: Score = {score}");

            Console.WriteLine("Press any key to to play again");
            Console.ReadLine();

        }
        public static void Division()
        {
            Random random = new Random();
            var score = 0;

            for (int i = 0; i <= 5; i++)
            {
                var num1 = random.Next(1, 10);
                var num2 = random.Next(1, 10);

                while (num1 % num2 != 0)
                {
                    num1 = random.Next(1, 10);
                    num2 = random.Next(1, 10);
                }
                Console.WriteLine($"{num1} / {num2} = ");
                int result = int.Parse(Console.ReadLine());

                if (result == num1 / num2)
                {
                    Console.WriteLine("You're correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You're wrong");
                }
            }
            Console.WriteLine($"You scored {score} points");

            Program.AddGame($"{DateTime.Now} - Division: Score = {score}");

            Console.WriteLine("Press any key to play again");
            Console.ReadLine();

        }
    }
}
