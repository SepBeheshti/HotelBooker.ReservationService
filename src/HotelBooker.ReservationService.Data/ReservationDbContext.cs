using HotelBooker.ReservationService.Data.Configuration;
using HotelBooker.ReservationService.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBooker.ReservationService.Data;

public class ReservationDbContext(DbContextOptions<ReservationDbContext> options) : DbContext(options)
{
    public DbSet<ReservationEntity> Reservations { get; set; } = null!;
    public DbSet<GuestEntity> Guests { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ReservationEntityConfiguration());
    }
}