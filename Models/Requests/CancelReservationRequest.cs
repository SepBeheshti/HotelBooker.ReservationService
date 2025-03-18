namespace HotelBooker.ReservationService.Api.Models.Requests;

public class CancelReservationRequest
{
    public string ReservationNumber { get; set; } = string.Empty;
    public string CancellationReason { get; set; } = string.Empty;
}