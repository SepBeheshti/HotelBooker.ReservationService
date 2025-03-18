namespace HotelBooker.ReservationService.Api.Models.Responses;

public class AvailabilityResponse
{
    public string RoomTypeId { get; set; } = string.Empty;
    public string RoomTypeName { get; set; } = string.Empty;
    public int AvailableRooms { get; set; }
    public decimal RatePerNight { get; set; }
}