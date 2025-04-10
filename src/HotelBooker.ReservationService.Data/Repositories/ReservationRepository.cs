﻿using HotelBooker.ReservationService.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBooker.ReservationService.Data.Repositories;

public class ReservationRepository(ReservationDbContext dbContext) : IReservationRepository
{
    public async Task<ReservationEntity?> GetByIdAsync(Guid id)
    {
        return await dbContext.Reservations
            .Include((r => r.Guest))
            .FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<ReservationEntity?> GetByReservationNumberAsync(string reservationNumber)
    {
        return await dbContext.Reservations
            .Include((r => r.Guest))
            .FirstOrDefaultAsync(r => r.ReservationNumber == reservationNumber);
    }

    public async Task<IEnumerable<ReservationEntity>> GetByGuestIdAsync(Guid guestId)
    {
        return await dbContext.Reservations
            .Include(r => r.Guest)
            .Where(r => r.GuestId == guestId)
            .ToListAsync();
    }

    public Task<IEnumerable<ReservationEntity>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetRoomTypeAvailabilityAsync(string roomTypeId, DateTime checkInDate, DateTime checkOutDate)
    {
        throw new NotImplementedException();
    }

    public async Task<ReservationEntity> CreateAsync(ReservationEntity reservation)
    {
        var entry = await dbContext.Reservations.AddAsync(reservation);
        await dbContext.SaveChangesAsync();
        
        return entry.Entity;
    }

    public Task UpdateAsync(ReservationEntity reservation)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}