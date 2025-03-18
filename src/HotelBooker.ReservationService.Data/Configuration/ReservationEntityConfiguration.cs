using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HotelBooker.ReservationService.Data.Entities;


namespace HotelBooker.ReservationService.Data.Configuration;

public class ReservationEntityConfiguration : IEntityTypeConfiguration<ReservationEntity>
{
    public void Configure(EntityTypeBuilder<ReservationEntity> builder)
    {
        builder.ToTable("Reservation", schema: "dbo");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ReservationNumber).IsRequired().HasMaxLength(20);
        builder.Property(x => x.GuestId).IsRequired().HasMaxLength(50);
        builder.Property(x => x.CheckInDate).IsRequired();
        builder.Property(x => x.CheckOutDate).IsRequired();
        builder.Property(x => x.NumberOfGuests).IsRequired();
        builder.Property(x => x.TotalAmount).IsRequired();
        builder.Property(x => x.ReservationStatus).IsRequired();
        
        builder.HasQueryFilter(r => !r.IsDeleted);
        
        builder.HasOne(r => r.Guest)
            .WithMany(g => g.Reservations)
            .HasForeignKey(r => r.GuestId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}