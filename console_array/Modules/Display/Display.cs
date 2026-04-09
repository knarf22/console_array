using console_array.Modules.Actions;
using console_array.Modules.AppDataData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array.Modules.Display
{
    public class DisplayDesign
    {

        private AppData _data;
        private MenuActions _menuActions;
        public DisplayDesign(AppData data)
        {
            _data = data;
            _menuActions = new MenuActions();
        }
        public void MainMenu(ref bool running)
        {
            Console.Clear();
            DisplayHeader();
            DisplayMenu(ref running);
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

        public void DisplayMenu(ref bool r)
        {

            Console.WriteLine("                           ---------------------------------");
            Console.WriteLine("                           | 1. Display List               |");
            Console.WriteLine("                           | 2. Add Item                   |");
            Console.WriteLine("                           | 3. Delete Item                |");
            Console.WriteLine("                           | 4. Exit                       |");
            Console.WriteLine("                           ---------------------------------");

            int option = int.Parse(Console.ReadLine());
            _menuActions.MenuOption(option, _data,ref r);
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


    }
}
