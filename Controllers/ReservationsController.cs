using Microsoft.AspNetCore.Mvc;

namespace HotelBooker.ReservationService.Api.Controllers;

public class ReservationsController : ControllerBase
{
    [ApiController]
    [Route("[api/[controller]")]
    public class ReservationController(
        IReservationService reservationService,
        IAvailabilityService availabilityService) : ControllerBase
    {
    }
}