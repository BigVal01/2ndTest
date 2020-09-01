using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {
        const double MIN_DIVIDER = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа поиска минимального делителя");
            bool check = false;
            int number = 0;
            do
            {
                Console.WriteLine("Введите натуральное число");
                string userNumber = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(userNumber);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (number > 0)
                    check = true;
            } while (!check);

            int devider = 0;
            for(double i = MIN_DIVIDER; i <= number; i++)
            {
                double temp = number / i;
                if(temp == (int) temp)
                {
                    devider = (int)i;
                    break;
                }
            }
            if(number == devider)
            {
                Console.WriteLine($"Число {number} - простое");
            }
            else
            {
                Console.WriteLine($"Минимальный делитель числа {number}: {devider}");
            }
            Console.ReadKey();

        }
    }
}
