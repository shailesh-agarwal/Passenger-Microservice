using PassengerMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassengerMicroservice.Repositories
{
    public interface ipassenger
    {
        List<TicketType> GetTicketType();
        List<BookingDetail> GetBookingDetail(int? id);
    }
}
