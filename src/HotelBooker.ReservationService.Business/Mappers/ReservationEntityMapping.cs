using HotelBooker.ReservationService.Business.Models;
using HotelBooker.ReservationService.Data.Entities;

namespace HotelBooker.ReservationService.Business.Mappers;

public class ReservationEntityMapping
{
    public ReservationEntity MapToEntity(Reservation reservation)
    {
        return new ReservationEntity()
        {
            Id = reservation.Id,
            ReservationNumber = reservation.ReservationNumber,
            Guest = new GuestEntity()
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