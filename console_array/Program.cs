
using console_array.Modules.Actions;
using console_array.Modules.Display;





var display = new Display();
var displayItems = new DisplayLists();
var menuOption = new MenuActions();


display.DisplayHeader();
display.DisplayMenu();

int option = int.Parse(Console.ReadLine());

menuOption.MenuOption(option);


//displayItems.DisplayAll();