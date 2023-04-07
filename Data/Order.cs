using Microsoft.AspNetCore.Identity;

namespace NeXenAdminPortal.Data;

public class Order
{
    public Guid Id { get; set; }

    public decimal Price { get; set; }
    public DateTime Date { get; set; }

    public Guid ClientId { get; set; }
    public Guid ProductId { get; set; }
    
    public required Client Client { get; set; }
    public required IdentityUser User { get; set; }
    public required Product Product { get; set; }
}