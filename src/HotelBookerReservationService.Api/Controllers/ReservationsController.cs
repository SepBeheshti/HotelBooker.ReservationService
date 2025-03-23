using HotelBooker.ReservationService.Api.Mappers;
using HotelBooker.ReservationService.Api.Models.Requests;
using HotelBooker.ReservationService.Api.Models.Responses;
using HotelBooker.ReservationService.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooker.ReservationService.Api.Controllers;

public class ReservationsController : ControllerBase
{
    [ApiController]
    [Route("[api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ReservationResponse>> GetReservationByIdAsync(Guid id)
        {
            var reservation = await _reservationService.GetReservationByIdAsync(id);

            if (reservation is null) return NotFound();

            return Ok(reservation);
        }

        [HttpPost]
        public async Task<ActionResult<ReservationResponse>> CreateReservation(CreateReservationRequest request)
        {
            var mappedReservationRequest = ReservationRequestMapper.MapToReservation(request);
            var createdReservation = await _reservationService.CreateReservationAsync(mappedReservationRequest);
            var mappedReservationResponse = ReservationResponseMapper.MapToReservationResponse(createdReservation);
            
            return mappedReservationResponse;
        }
    }
}