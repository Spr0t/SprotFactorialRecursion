using System;

namespace LessonHW7
{
    internal class Program
    {
        static void Main(string[] args)
        {

                //Задача: запросить у пользователя число, факториал которого необходимо вычислить и произвести вычисление. 
                //Затем вывести результат вычисления. Восклицательный знак запрашивать не надо, 
                //кроме того, в C# такой операции нет. Для вычисления факториала надо производить перемножение.



            Console.WriteLine("Введите число факториал которого вы хотите вычислить:");

            int input = Factorial(int.Parse(Console.ReadLine()));

            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);    
            }

            Console.WriteLine($"Факториал вашего числа равен : {input}");
            Console.ReadLine();
        }
    }
}
