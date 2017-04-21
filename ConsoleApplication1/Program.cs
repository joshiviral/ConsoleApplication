using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;   // Takes Input from the User
            Console.WriteLine("No of Package Quantities");
            x = Convert.ToDouble(Console.ReadLine());
            double a = 99, j=0,s;
            /*
             *a is the retail value of 1 package
              s is the variable which stores the total amount before discount
              j is the variable which calculates the total amount after discount
             */
            //The condition which will calculate 20% discount
            if (x == 10 || x < 20)
            {
                s = x * a;//
                j = s - s * (0.20);
                Console.WriteLine("Discount is 20% \n");
                Console.WriteLine("Total amount is " +j);
                       
            }
            //The condition which will calculate 30% discount
            else if (x == 20 || x < 50)
            {
                s = x * a;
                j = s - s * (0.30);
                Console.WriteLine("Discount is 30% \n");
                Console.WriteLine("Total amount is " + j);
            }
            //The condition which will calculate 40% discount
            else if (x == 50 || x < 100)
            {
                s = x * a;
                j = s - s * (0.40);
                Console.WriteLine("Discount is 40% \n");
                Console.WriteLine("Total amount is " + j);
            }
            //The condition which will calculate 50% discount
            else if (x >= 100)
            {
                s = x * a;
                j = s - s * (0.50);
                Console.WriteLine("Discount is 50% \n");
                Console.WriteLine("Total amount is " + j);
            }

            else {
                Console.WriteLine(" NO discount offered..");
            }
            Console.ReadLine();
        }
    }
}