using console_array.Modules.AppDataData;
using console_array.Modules.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array.Modules.Actions
{
    public class ActionItems
    {
        public void DisplayAll(AppData data, bool isOutside = true)
        {
            for (int i = 0; i < data.Items.Count; i++)
            {
                Console.WriteLine($"                           Item number {i + 1} :");

                foreach (var item in data.Items[i])
                {
                    Console.WriteLine($"                           - {item}");
                }
            }
            if(isOutside)
            { 
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
        public void AddItem(AppData data)
        {
            DisplayAll(data,false);
            Console.WriteLine("Enter index");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new item");
            string new_item = Console.ReadLine();
            data.Items[index - 1].Add(new_item);


            Console.WriteLine($"Item added is : {new_item}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        public void RemoveItem(AppData data)
        {
            DisplayAll(data,false);
            Console.WriteLine("Choose index");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter item to remove");
            int itemToRemove = int.Parse(Console.ReadLine());
            var item = data.Items[index - 1][itemToRemove - 1];
            data.Items[index - 1].RemoveAt(itemToRemove -1);

            Console.WriteLine($"Item removed is : {item}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
