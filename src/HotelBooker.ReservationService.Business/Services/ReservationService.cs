using HotelBooker.ReservationService.Business.Models;

namespace HotelBooker.ReservationService.Business.Services;

public class ReservationService(IReservationService reservationService) : IReservationService
{
    public Task<Reservation> GetReservationByIdAsync(Guid id)
    {
        return reservationService.GetReservationByIdAsync(id);
    }

    public Task<Reservation> GetReservationByNumberAsync(string reservationNumber)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Reservation>> GetReservationsByGuestIdAsync(Guid guestId)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> CreateReservationAsync(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> UpdateReservationAsync(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CancelReservationAsync(string reservationNumber, string cancellationReason)
    {
        throw new NotImplementedException();
    }

    public Task<string> GenerateReservationNumberAsync()
    {
        throw new NotImplementedException();
    }
}