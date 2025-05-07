// See https://aka.ms/new-console-template for more information
using pre.events.cons.events;

Console.WriteLine("Hello, World!");

var inventory = new Inventory();
inventory.Products = new List<Product> 
{
    new Product{Id = 1 ,Name = "Zeep"},
    new Product{Id = 2,Name = "Water"},
    new Product{Id = 3,Name = "Choco"},
    new Product{Id = 4,Name = "Drank"},
    new Product{Id = 5,Name = "Bollen"},
    new Product{Id = 6,Name = "Kleenex"},
    new Product{Id = 7,Name = "Baby oil"},
    new Product{Id = 8,Name = "Selder"},
};
var inventoryEventhandlers = new InventoryEventHandlers();
inventory.ProductInventoryEventEmpty += inventoryEventhandlers.HandleInventoryEmpty;
inventory.ProductInventoryEventFull += inventoryEventhandlers.HandleInventoryFull;

for(int i = 0;i<9;i++)
{
    inventory.SellProduct();
}
for (int i = 0; i < 14; i++)
{
    inventory.BuyProduct();
}
