using System.ComponentModel.DataAnnotations;

namespace NeXenAdminPortal.Data;

public class Client
{
    public Guid Id { get; set; }
    public required string ClientName { get; set; }
    [Range(0, 100)] public int NumberOfUsers { get; set; }
    public bool SpecialOffer { get; set; }
}