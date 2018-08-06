using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifstatmentpractice
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("please enter a number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter another number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {

                Console.WriteLine("Number 1 is greater");
                Console.ReadLine();

            }


            else if (num1 < num2)
            {

                Console.WriteLine("The second number is greater");
                Console.ReadLine();

            }
            
           else if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal");
                Console.ReadLine();

            }
                
            
            Console.ReadKey();

        
            Console.WriteLine("Now let's add or subtract our numbers together, Press Enter to continue");
            string apple = Console.ReadLine();




            if(apple == "+")
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
            else if(apple == "-")
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));

            //grade example
            int grade = 0;
            Console.WriteLine("Please enter your grade: ");
            grade = int.Parse(Console.ReadLine());
            if (grade >= 90 && grade <= 100)
                Console.WriteLine("cheater");

            


            Console.ReadLine();













        }
    }
}
