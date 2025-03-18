namespace HotelBooker.ReservationService.Data.Entities;

public class ReservationEntity
{
    public Guid Id { get; set; }
    public string ReservationNumber { get; set; } = string.Empty;
    public Guid GuestId { get; set; }
    public string RoomTypeId { get; set; } = string.Empty;
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int NumberOfGuests { get; set; }
    public decimal TotalAmount { get; set; }
    public string ReservationStatus { get; set; } = string.Empty;
    public string? SpecialRequests { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool IsDeleted { get; set; }

    // Navigation properties
    public GuestEntity Guest { get; set; } = null!;
}