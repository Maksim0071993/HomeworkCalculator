using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    class Program
    {          
        static void Main(string[] args)
        {
            double result = 0;
            bool endApp = false;        

            while (!endApp)
            {
                Console.Write("Введите число 1: ");
                string num1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(num1, out cleanNum1))
                {
                    Console.Write("Вы ввели неверный символ, введите числовое значение: ");
                    num1 = Console.ReadLine();
                }

                Console.Write("Введите число 2: ");
                string num2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(num2, out cleanNum2))
                {
                    Console.Write("Вы ввели неверный символ, введите числовое значение: ");
                    num2 = Console.ReadLine();
                }

                Console.WriteLine("Введите знак + - * / :");

                string op = Console.ReadLine();

                try
                {
                    result = Operations.Operation(cleanNum1, cleanNum2, op);
                     Console.WriteLine("Результат: {0:0.##}\n", result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Внимание! Возникла ошибка.\n - Details: " + ex.Message);
                }
            
                Console.Write("Если вы хотите завершить программу нажмите e, для продолжения любую кнопку : ");
                if (Console.ReadLine() == "e") endApp = true;
                Console.Clear();
            }

            return;         
        }      
    }
}

