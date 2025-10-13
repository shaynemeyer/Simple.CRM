namespace Simple.CRM.WebApp.Data.Models;

public class VacationPackage
{
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int DurationInDays { get; set; }

    // Navigation properties
    public ICollection<Booking> Bookings { get; set; } = [];
}
