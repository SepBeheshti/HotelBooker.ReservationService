using HotelBooker.ReservationService.Api.Models.Responses;
using HotelBooker.ReservationService.Business.Models;

namespace HotelBooker.ReservationService.Api.Mappers;

public class ReservationResponseMapper
{
    public static ReservationResponse MapToReservationResponse(Reservation reservation)
    {
        return new ReservationResponse()
        {
            ReservationNumber = reservation.ReservationNumber,
            Guest = new GuestInfoResponse()
            {
                Email = reservation.Guest.Email,
                FirstName = reservation.Guest.FirstName,
                LastName = reservation.Guest.LastName,
                PhoneNumber = reservation.Guest.PhoneNumber
            },
            CheckInDate = reservation.CheckInDate,
            CheckOutDate = reservation.CheckOutDate,
            CreatedDate = reservation.CreatedDate,
            NumberOfGuests = reservation.NumberOfGuests,
            RoomTypeId = reservation.RoomTypeId,
            SpecialRequests = reservation.SpecialRequests,
            Status = reservation.Status.ToString(),
            TotalAmount = reservation.TotalAmount
        };
    }
}