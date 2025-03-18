using HotelBooker.ReservationService.Data.Entities;

namespace HotelBooker.ReservationService.Data.Repositories;

public interface IReservationRepository
{
    Task<ReservationEntity?> GetByIdAsync(Guid id);
    Task<ReservationEntity?> GetByReservationNumberAsync(string reservationNumber);
    Task<IEnumerable<ReservationEntity>> GetByGuestIdAsync(Guid guestId);
    Task<IEnumerable<ReservationEntity>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<int> GetRoomTypeAvailabilityAsync(string roomTypeId, DateTime checkInDate, DateTime checkOutDate);
    Task<ReservationEntity> CreateAsync(ReservationEntity reservation);
    Task UpdateAsync(ReservationEntity reservation);
    Task DeleteAsync(Guid id);
    Task<bool> SaveChangesAsync();
}