namespace NeXenAdminPortal.Data;

public class Subscription
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }

    public Guid OrderId { get; set; }
    public required Order Order { get; set; }

}