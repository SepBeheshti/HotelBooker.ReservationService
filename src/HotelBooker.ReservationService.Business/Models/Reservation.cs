using HotelBooker.ReservationService.Business.Enums;

namespace HotelBooker.ReservationService.Business.Models;

public class Reservation
{
    public Guid Id { get; set; }
    public string ReservationNumber { get; set; } = string.Empty;
    public Guest Guest { get; set; } = null!;
    public string RoomTypeId { get; set; } = string.Empty;
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int NumberOfGuests { get; set; }
    public decimal TotalAmount { get; set; }
    public ReservationStatus Status { get; set; }
    public string? SpecialRequests { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
}