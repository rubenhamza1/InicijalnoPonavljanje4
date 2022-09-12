using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Unesi vrijednosti stranica trokuta: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Molim unesti vrijednost koja je veća od 0.");
            }
            else { Console.WriteLine("Trokut nije pravokutan.")};
                

            if (z > y && z > x && (y*y) + (x*x) == (z*z))
            {
                Console.WriteLine("Trokut je pravokutan.");
            }
            else if(x > y && x > z && (y*y) + (z*z) == (x*x))
            {
                Console.WriteLine("Trokut je pravokutan.");
            }
            else if (y > x && y > z && (x * x) + (z * z) == (y * y))
            {
                Console.WriteLine("Trokut je pravokutan.");
            }

            Console.ReadKey();
         
        }
    }
}
