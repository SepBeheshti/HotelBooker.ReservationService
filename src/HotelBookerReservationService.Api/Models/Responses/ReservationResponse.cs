namespace HotelBooker.ReservationService.Api.Models.Responses;

public class ReservationResponse
{
    public string ReservationNumber { get; set; } = string.Empty;
    public GuestInfoResponse Guest { get; set; } = null!;
    public string RoomTypeId { get; set; } = string.Empty;
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int NumberOfGuests { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? SpecialRequests { get; set; }
    public DateTime CreatedDate { get; set; }
}