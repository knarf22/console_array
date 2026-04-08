using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array.Modules.Actions
{
    public class DisplayLists
    {
        public void DisplayAll()
        {
            List<List<string>> all_items = new List<List<string>>();
            List<string> firstItem = new List<string>();
            List<string> secondItem = new List<string>();

            firstItem.Add("jose");
            firstItem.Add("frank");
            firstItem.Add("gonzales");

            secondItem.Add("soya");
            secondItem.Add("cindie");
            secondItem.Add("vira");
            secondItem.Add("dolly");

            all_items.Add(firstItem);
            all_items.Add(secondItem);

            for (int i = 0; i < all_items.Count; i++)
            {
                Console.WriteLine($"Item number {i + 1} :");

                foreach (var item in all_items[i])
                {
                    Console.WriteLine($" - {item}");
                }
            }
        }
    }
}
