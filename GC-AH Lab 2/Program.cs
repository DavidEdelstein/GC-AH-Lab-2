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
            // James - like that you used a while true to continue to run your program, this is 
            // a pretty common pattern :)
            while (true)
            {
                // James - okay so you are using your "false" condition to hit the loop by default.
                // an alternative way to handle this input is just put it in it's own loop and inverse the if
                // statement, for example...
                //
                // while (true)
                // {
                //      if (!decimal.TryParse(Console.ReadLine(), out decimal width))  notice that im using a !
                //      {
                //          continue;
                //      }
                //      break;
                // }
                //
                // Also, with this Console, there is no indication to the user that they entered the wrong 
                // type of information.  only asking for hte same information again.
                Console.Write("Please enter the WIDTH of the room:");
                if (decimal.TryParse(Console.ReadLine(), out decimal width))
                {
                    // James - refer to line 32, though for this input, you are informing the 
                    // user that they put in the wrong information.
                    Console.Write("Please enter the LENGTH of the room:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal length))
                    {

                        Console.WriteLine("Area:" + (width * length));
                        Console.WriteLine("Perimeter:" + 2 * (length + width));


                            // James - if the user enters anything other than 2, the program will continue.
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
                        
                           // James - lots of whitespace here, I would be careful with these gaps, this can
                           // make your program hard to follow sometimes.

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
    

