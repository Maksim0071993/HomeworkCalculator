using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    public class Operations
    {
        public static double Operation(double num1, double num2, string sing)
        {
            double result = 0;
            switch (sing)
            {

                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    while (num2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                        Console.WriteLine("Введите число 2");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }

                     result = num1 / num2;
                    break;
                
            }
            
            return result;          
        }
    }
}
