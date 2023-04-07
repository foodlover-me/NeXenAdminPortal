using System.ComponentModel;

namespace NeXenAdminPortal.Data;

public class Price
{
    public Guid Id { get; set; }
    
    [DisplayName("Minimum number of users (0 or empty if applies to all quantities)")]
    public int MinimumNumberOfUsers { get; set; }
    
    [DisplayName("Special Offer")]
    public bool SpecialOffer { get; set; }
    
    public decimal Amount { get; set; }

    public Guid ProductId { get; set; }

    public Product? Product { get; set; }
}