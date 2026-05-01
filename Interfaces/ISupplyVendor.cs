namespace InventorySystem;

public interface ISupplyVendor
{
    string VendorID { get; set; }
    string VendorItemID { get; set; }
    double ItemCost { get; set; }
}