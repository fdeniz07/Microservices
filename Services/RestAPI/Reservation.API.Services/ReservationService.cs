using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Services
{
    public class ReservationService:IReservationService
    {
        #region Implementation of IReservationService

        public ReservationDTO GetResByBookingNumber(int BookingNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(10000),
                BookingDate = DateTime.Now,
                CheckinDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37),
                BookingNumber = BookingNumber
            };
        }

        #endregion
    }
}
