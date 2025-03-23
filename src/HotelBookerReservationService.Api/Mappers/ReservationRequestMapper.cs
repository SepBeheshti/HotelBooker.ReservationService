using HotelBooker.ReservationService.Api.Models;
using HotelBooker.ReservationService.Api.Models.Requests;
using HotelBooker.ReservationService.Business.Models;

namespace HotelBooker.ReservationService.Api.Mappers;

public class ReservationRequestMapper
{
    public static Reservation MapToReservation(CreateReservationRequest createReservationRequest)
    {
        return new Reservation()
        {
            RoomTypeId = createReservationRequest.RoomTypeId,
            CheckInDate = createReservationRequest.CheckInDate,
            CheckOutDate = createReservationRequest.CheckOutDate,
            NumberOfGuests = createReservationRequest.NumberOfGuests,
            Guest = new Guest()
            {
                FirstName = createReservationRequest.Guest.FirstName,
                LastName = createReservationRequest.Guest.LastName,
                Email = createReservationRequest.Guest.Email,
                PhoneNumber = createReservationRequest.Guest.PhoneNumber
            },
            SpecialRequests = createReservationRequest.SpecialRequests
        };
    }
}