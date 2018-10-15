using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_AH_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Please enter the WIDTH of the room:");
                if (decimal.TryParse(Console.ReadLine(), out decimal width))
                {
                    Console.Write("Please enter the LENGTH of the room:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal length))
                    {

                        Console.WriteLine("Area:" + (width * length));
                        Console.WriteLine("Perimeter:" + 2 * (length + width));


                       
                            Console.WriteLine("Enter 1 to continue or 2 to stop:");
                            var answer = Console.ReadLine();
                            if(answer == "1")
                            {
                              continue;
                            }
                            else if (answer == "2")
                            {
                              break;
                            }
                        



                    }
                    else
                    {
                        Console.WriteLine("Please enter valid inputs.");
                    }
                  
                }
            

            }


        }

    }
}
    

