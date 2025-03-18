using HotelBooker.ReservationService.Business.Models;

namespace HotelBooker.ReservationService.Business.Services;

public interface IReservationService
{
        Task<Reservation> GetReservationByIdAsync(Guid id);
        Task<Reservation> GetReservationByNumberAsync(string reservationNumber);
        Task<IEnumerable<Reservation>> GetReservationsByGuestIdAsync(Guid guestId);
        Task<Reservation> CreateReservationAsync(Reservation reservation);
        Task<Reservation> UpdateReservationAsync(Reservation reservation);
        Task<bool> CancelReservationAsync(string reservationNumber, string cancellationReason);
        Task<string> GenerateReservationNumberAsync();
}