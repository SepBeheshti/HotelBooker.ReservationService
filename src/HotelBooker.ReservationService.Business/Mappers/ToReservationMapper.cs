using HotelBooker.ReservationService.Business.Models;
using HotelBooker.ReservationService.Data.Entities;

namespace HotelBooker.ReservationService.Business.Mappers;

public class ToReservationMapper
{
    public static Reservation MapToReservation(ReservationEntity reservation)
    {
        return new Reservation()
        {
            Id = reservation.Id,
            ReservationNumber = reservation.ReservationNumber,
            Guest = new Guest()
            {
                FirstName = reservation.Guest.FirstName,
                LastName = reservation.Guest.LastName,
                Email = reservation.Guest.Email,
                PhoneNumber = reservation.Guest.PhoneNumber
            },
            RoomTypeId = reservation.RoomTypeId
        };
    }
}