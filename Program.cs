using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAndClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            char sex = 'f';

            System.Console.WriteLine("Starting tests... (day:{0}, sex:{1})",
                                      day, sex);

            if (day >= 1 && day <= 7)      //day from 1 to 7? 
            {
                System.Console.WriteLine("Day is from 1 to 7");
            }
            if (sex == 'm' || sex == 'f')  // Male or female?
            {
                System.Console.WriteLine("Sex is male or female.");
            }

            System.Console.WriteLine("Done with the checks Mike.");
            System.Console.ReadKey();
        }
    }
}