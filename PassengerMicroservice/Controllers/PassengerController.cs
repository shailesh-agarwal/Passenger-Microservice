using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PassengerMicroservice.Repositories;

namespace PassengerMicroservice.Controllers
{
    [ApiController]
    public class PassengerController : ControllerBase
    {
        ipassenger pass;

        public PassengerController(ipassenger _pass)
        {
            pass = _pass;
        }

        [HttpGet]
        [Route("api/Passenger/GetTicketType")]
        public IActionResult GetTicketType()
        {
            try
            {
                var tickets = pass.GetTicketType();

                if (tickets != null)
                {
                    return Ok(tickets);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/Passenger/GetBookingDetail")]
        public IActionResult GetBookingDetail(int? id)
        {
            try
            {
                var booking = pass.GetBookingDetail(id);

                if (booking != null)
                {
                    return Ok(booking);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}