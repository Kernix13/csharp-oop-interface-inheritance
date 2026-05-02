namespace InventorySystem;

// Not currently being used
public interface IPurchaseOrder
{
    string VendorID { get; }
    string ItemID { get; }
    int OrderQuantity { get; set; }
}