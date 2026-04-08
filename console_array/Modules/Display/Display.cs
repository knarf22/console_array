using console_array.Modules.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array.Modules.Display
{
    public class DisplayDesign
    {
        public void MainMenu()
        {
            Console.Clear();
            DisplayHeader();
            DisplayMenu();
        }
        public void DisplayHeader()
        {
            DisplaySpace();
            Console.WriteLine("                            *******************************");
            Console.WriteLine("                            *******************************");
            Console.WriteLine("                            ***     WELCOME TO MY APP   ***");
            Console.WriteLine("                            *******************************");
            Console.WriteLine("                            *******************************");
            DisplaySpace();
        }

        public void DisplayMenu()
        {
            var menuOption = new MenuActions();

            Console.WriteLine("                           ---------------------------------");
            Console.WriteLine("                           | 1. Display List               |");
            Console.WriteLine("                           | 2. Add List                   |");
            Console.WriteLine("                           | 3. Delete List                |");
            Console.WriteLine("                           ---------------------------------");

            int option = int.Parse(Console.ReadLine());
            menuOption.MenuOption(option);
        }

        public void DisplaySpace()
        {
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
        }

        public void Continue()
        {
            Console.WriteLine("Would you like to continue? Y/N");
            var cont = Console.ReadLine();
            if(cont.ToLower() == "y")
            {
                MainMenu();
            }
            else
            {
                return;
            }
        }


    }
}
