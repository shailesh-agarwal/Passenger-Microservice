using System;
using System.Collections.Generic;

namespace PassengerMicroservice.Models
{
    public partial class BookingDetail
    {
        public int Id { get; set; }
        public int? PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string Category { get; set; }
        public double? Price { get; set; }
    }
}
