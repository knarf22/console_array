using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array.Modules.Actions
{
    public class MenuActions
    {

        public void MenuOption(int opt)
        {
            var displayItems = new DisplayLists();

            switch (opt)
            {
                case 1:
                    Console.Clear();
                    displayItems.DisplayAll();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("option 2");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("option 3");
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;

            }
        }
    }
}
