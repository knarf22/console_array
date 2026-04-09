
using console_array.Modules.Actions;
using console_array.Modules.AppDataData;
using console_array.Modules.Data;
using console_array.Modules.Display;



AppData data = new AppData();
KeepRunning running = new KeepRunning();


List<string> first = ["jose", "frank", "gonzales"];
List<string> second = ["soya", "cindie", "vira", "dolly"];
List<List<string>> allItems = new List<List<string>> { first, second };
data.Items = allItems;
var display = new DisplayDesign(data, running);

while(running.IsRunning)
{ 
    display.MainMenu();
}



