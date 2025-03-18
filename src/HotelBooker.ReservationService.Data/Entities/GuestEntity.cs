namespace HotelBooker.ReservationService.Data.Entities;

public class GuestEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
        
    // Navigation properties
    public ICollection<ReservationEntity> Reservations { get; set; } = new List<ReservationEntity>();
}