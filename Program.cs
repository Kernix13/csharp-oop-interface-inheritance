using InventorySystem;
using System.Globalization;

IInventoryItem product1 = new DatedProduct();
Console.WriteLine(product1.DisplayItemInfo());

StandardProduct product2 = new StandardProduct();
Console.WriteLine(product2.DisplayItemInfo());
