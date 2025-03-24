using HotelBooker.ReservationService.Business.Mappers;
using HotelBooker.ReservationService.Business.Models;
using HotelBooker.ReservationService.Data.Entities;
using HotelBooker.ReservationService.Data.Repositories;

namespace HotelBooker.ReservationService.Business.Services;

public class ReservationService : IReservationService
{
    public static IReservationRepository _reservationRepository;
    
    public ReservationService(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }
    
    public async Task<Reservation> GetReservationByIdAsync(Guid id)
    {
        var reservationResponse = await _reservationRepository.GetByIdAsync(id);
        var mappedReservation = ToReservationMapper.MapToReservation(reservationResponse);
        
        return mappedReservation;
    }

    public async Task<Reservation> GetReservationByNumberAsync(string reservationNumber)
    {
        var reservationResponse = await _reservationRepository.GetByReservationNumberAsync(reservationNumber);
        var mappedReservation = ToReservationMapper.MapToReservation(reservationResponse);

        return mappedReservation;
    }

    public async Task<IEnumerable<Reservation>> GetReservationsByGuestIdAsync(Guid guestId)
    {
        var reservationEntities  = await _reservationRepository.GetByGuestIdAsync(guestId);
        var mappedReservation = ToReservationMapper.MapToReservation(reservationEntities);

        return mappedReservation;
    }

    public async Task<Reservation> CreateReservationAsync(Reservation reservation)
    {
        var mappedToReservationEntity = ToReservationEntityMapper.MapToReservationEntity(reservation);
        var createdReservation = await _reservationRepository.CreateAsync(mappedToReservationEntity);
        var mappedToReservation = ToReservationMapper.MapToReservation(createdReservation);
        
        return mappedToReservation;
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