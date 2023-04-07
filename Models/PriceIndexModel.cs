using NeXenAdminPortal.Data;

namespace NeXenAdminPortal.Models;

public class PriceIndexModel
{
    public required IReadOnlyCollection<Price> Prices { get; set; }
    
    public Guid ProductId { get; set; }
}