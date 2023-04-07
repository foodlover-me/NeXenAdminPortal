namespace NeXenAdminPortal.Data;

public class Price
{
    public Guid Id { get; set; }
    public int MinimumNumberOfUsers { get; set; }
    public bool SpecialOffer { get; set; }

    public Guid ProductId { get; set; }

    public required Product Product { get; set; }
}