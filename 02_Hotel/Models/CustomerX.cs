using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hotel
{
    public partial class Customer
    {
        public int BookingCount {
            get => (from customer in Program.Db.Customers.ToList()
                    join booking in Program.Db.Bookings on this equals booking.Customers
                    select booking).Distinct().Count()
            ;
        }

        public string FullAddress {
            get => $"{Address}\n" +
                   $"{PostalCode} {City}\n" +
                   $"{Country}";
        }

        public string FullName { get => $"{FirstName} {LastName}"; }
    }
}
