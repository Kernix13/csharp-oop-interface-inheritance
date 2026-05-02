using InventorySystem;
// Do I need this:
using System.Globalization;

IInventoryItem product1 = new DatedProduct("mnop", 150, 0, 0);
Console.WriteLine(product1.DisplayItemInfo());

IInventoryItem product2 = new StandardProduct("xyz123", 10, 50, 17);
Console.WriteLine(product2.DisplayItemInfo());
