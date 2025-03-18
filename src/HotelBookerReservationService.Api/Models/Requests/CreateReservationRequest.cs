namespace HotelBooker.ReservationService.Api.Models.Requests;

public class CreateReservationRequest
{
    public string RoomTypeId { get; set; } = string.Empty;
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int NumberOfGuests { get; set; }
    public GuestInfo Guest { get; set; } = null!;
    public string? SpecialRequests { get; set; }
}