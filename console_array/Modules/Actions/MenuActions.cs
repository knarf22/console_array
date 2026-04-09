using console_array.Modules.AppDataData;
using console_array.Modules.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array.Modules.Actions
{
    public class MenuActions
    {
        private KeepRunning _running;
        public MenuActions(KeepRunning running)
        {
            _running = running;
        }
        public void MenuOption(int opt, AppData data)
        {
            var action = new ActionItems();

            switch (opt)
            {
                case 1:
                    Console.Clear();
                    action.DisplayAll(data);
                    break;
                case 2:
                    Console.Clear();
                    action.AddItem(data);
                    break;
                case 3:
                    Console.Clear();
                    action.RemoveItem(data);
                    break;
                case 4:
                    _running.IsRunning = false;
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;

            }
        }
    }
}
