using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array.Modules.Display
{
    public class Display
    {
        public void DisplayHeader()
        {
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                            *******************************");
            Console.WriteLine("                            *******************************");
            Console.WriteLine("                            ***     WELCOME TO MY APP   ***");
            Console.WriteLine("                            *******************************");
            Console.WriteLine("                            *******************************");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("                           ---------------------------------");
            Console.WriteLine("                           | 1. Display List               |");
            Console.WriteLine("                           | 2. Add List                   |");
            Console.WriteLine("                           | 3. Delete List                |");
            Console.WriteLine("                           ---------------------------------");
        }


    }
}
