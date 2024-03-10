using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Task3
    {
        public static void Main()
        {
            Console.Write("Введите любое положительное число: ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0) { Console.WriteLine("Чётное"); } else { Console.WriteLine("Не чётное"); }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + "\n03.Введите корректные данные!");
                return;
            }           

        }
    }
}
