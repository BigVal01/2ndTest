using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    class Program
    {
        const int DISPLAY_WEATHER = 1;
        static void Main(string[] args)
        {
            List<string> weather = new List<string> { "В городе погода ясная, светит солныфко", "Очень дождливо, не забудьте зонт", "Снег за окном, очень скользко",
                                                      "На улице пасмурно, возможен дождь", "Очень ветрено, не простудитесь"};
            int choise = 0;
            Random rand = new Random();
            do
            {
                Console.WriteLine("1. Узнать погоду в городе");
                try
                {
                    choise = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (choise)
                {
                    case DISPLAY_WEATHER:
                        Console.WriteLine(weather[rand.Next(0, weather.Count)]);
                        break;
                }
            } while (choise != 1);

            Console.ReadKey();
        }
    }
}
