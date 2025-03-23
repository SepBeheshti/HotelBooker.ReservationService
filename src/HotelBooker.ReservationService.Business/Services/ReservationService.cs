using HotelBooker.ReservationService.Business.Models;
using HotelBooker.ReservationService.Data.Repositories;

namespace HotelBooker.ReservationService.Business.Services;

public class ReservationService : IReservationService
{
    public static IReservationRepository _reservationRepository;
    
    public ReservationService(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }
    
    public Task<Reservation> GetReservationByIdAsync(Guid id)
    {
        return _reservationRepository.GetByIdAsync(id);
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
        reservat
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