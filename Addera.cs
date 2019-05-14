using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nummer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Addera med: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("svar: " + (num1 + num2 ));

            Console.ReadLine();
        }
    }
}
