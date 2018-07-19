using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Conti()
        {
            Console.WriteLine("Would you like to Re-Enter a number?(y/n)");
            string input2 = Console.ReadLine();
            if (input2 == "y" || input2 == "Y")
            {
                Main();
            }
            else
            {
                return;
            }
             
        } 
        static void Main()
        {
            Console.WriteLine("Enter a Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number     Squared     Cubed");
            Console.WriteLine("=======    =======     ======");

            for (int i = 1; i < num1 + 1; i++)
            {
                int number = i;
                int squared = i * i;
                int Cubed = i * i * i;
                string nums = number.ToString();
                string squars = squared.ToString();
                string cubes = Cubed.ToString();
                Console.WriteLine(nums.PadRight(11) + squars.PadRight(12) + cubes.PadRight(0));
                // Console.Write(squars.PadRight(10));
                // Console.WriteLine(cubes.PadRight(35));

              
                
               
                
            }
            Conti();
        } 

    }
}

