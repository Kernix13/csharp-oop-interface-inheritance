namespace InventorySystem;

public interface IPurchaseOrder
{
    string VendorID { get; }
    string ItemID { get; }
    int OrderQuantity { get; set; }
}