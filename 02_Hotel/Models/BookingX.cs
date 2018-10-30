using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hotel
{
    public partial class Booking
    {
        public bool IsValid {
            get => (DateTime.Now - this.DateBooked).Days < 10
                   || IsPaid;
        }

        public bool IsPaid
        {
            get => (this.Payments != null);
            //&& (DateTime.Now - this.Payments.DatePaid).Days > 10
            //&& this.Payments.Amount >= Price);
        }

        public Booking(Booking booking)
        {
            DateFrom = booking.DateFrom;
            DateTo = booking.DateTo;
            Price = booking.Price;
            Customers = booking.Customers;
        }

        public int ExtraBedsCount {
            get => Program.Db.ExtrabedBookings.ToList().Count(x => x.Bookings == this);
        }

        public string Booker { get => Customers.FirstName + " " + Customers.LastName; }
    }
}
