namespace NeXenAdminPortal.Data;

public class Product
{
    public Guid Id { get; set; }
    public required string Description { get; set; }
    public bool Subscribable { get; set; }
}