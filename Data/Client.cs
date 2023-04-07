namespace NeXenAdminPortal.Data;

public class Client
{
    public Guid Id { get; set; }
    public required string ClientName { get; set; }
    public int NumberOfUsers { get; set; }
    public bool SpecialOffer { get; set; }

}