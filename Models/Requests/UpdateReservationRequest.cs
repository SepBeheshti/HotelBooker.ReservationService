namespace HotelBooker.ReservationService.Api.Models.Requests;

public class UpdateReservationRequest
{
    public string ReservationNumber { get; set; } = string.Empty;
    public string? RoomTypeId { get; set; }
    public DateTime? CheckInDate { get; set; }
    public DateTime? CheckOutDate { get; set; }
    public int? NumberOfGuests { get; set; }
    public string? SpecialRequests { get; set; }
}
