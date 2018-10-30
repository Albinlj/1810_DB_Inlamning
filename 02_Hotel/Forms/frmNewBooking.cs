using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Hotel
{
    public partial class frmNewBooking : Form
    {
        int people;
        private Customer _bookingCustomer;

        public frmNewBooking(Customer bookingCustomer)
        {
            InitializeComponent();
            this.Text = "Booking a room for " + bookingCustomer.FullName;
            _bookingCustomer = bookingCustomer;
            cbCustomers.Items.AddRange(Program.Db.Customers.ToArray());
            cbCustomers.Sorted = true;
            cbCustomers.SelectedItem = bookingCustomer;
            cbBookingPeople.SelectedIndex = 0;
            dgBookingRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtpBookingFrom.Value = DateTime.Now;
            dtpBookingFrom.MinDate = DateTime.Now;
            UpdateDatagrids();
        }

        public frmNewBooking(Booking oldBooking)
        {
            InitializeComponent();
            _bookingCustomer = oldBooking.Customers;
            cbCustomers.SelectedItem = oldBooking.Customers;
            cbBookingPeople.SelectedIndex = 0;
            dtpBookingFrom.Value = oldBooking.DateFrom;
            dtpBookingTo.Value = oldBooking.DateTo;

            cbCustomers.Items.AddRange(Program.Db.Customers.ToArray());
            cbCustomers.Sorted = true;
            cbCustomers.SelectedItem = _bookingCustomer;
        }


        private void UpdateDatagrids()
        {
            people = int.Parse(cbBookingPeople.SelectedItem.ToString());
            if (dtpBookingTo.Value < dtpBookingFrom.Value)
            {
                dtpBookingTo.Value = dtpBookingFrom.Value.AddDays(1);
            }
            dtpBookingTo.MinDate = dtpBookingFrom.Value.AddDays(1);

            var roomsWithOverlappingBookings = (from room in Program.Db.Rooms.ToList()
                                                join booking in Program.Db.Bookings.ToList()
                                                on room equals booking.Room
                                                where Utility.IsOverlapping(booking.DateFrom, booking.DateTo, dtpBookingFrom.Value, dtpBookingTo.Value)
                                                where booking.IsValid
                                                select room).ToList();

            var availableRooms = (from r in Program.Db.Rooms.ToList()
                                  where r.Beds + Math.Min(GetAvailableExtraBeds().Count(), r.MaxExtraBeds) >= people && !roomsWithOverlappingBookings.Contains(r)
                                  select r).ToList();

            dgBookingRooms.DataSource = availableRooms;

        }

        private List<Extrabed> GetAvailableExtraBeds()
        {
            var notAvailableBeds = (from eb in Program.Db.Extrabeds1.ToList()
                                    join ebb in Program.Db.ExtrabedBookings.ToList() on eb equals ebb.Extrabed
                                    from b in Program.Db.Bookings.ToList()
                                    where b.ExtrabedBooking.Contains(ebb)
                                    where b.IsValid
                                    select eb);

            var availableBeds = (from extrabed in Program.Db.Extrabeds1.ToList()
                                 where !notAvailableBeds.Contains(extrabed)
                                 select extrabed).ToList();

            return availableBeds;
        }

        private void BookSelectedRoom()
        {
            if ((dtpBookingTo.Value.Date - dtpBookingFrom.Value.Date).Days > 0)
            {
                Room selectedRoom = (Room)dgBookingRooms.CurrentRow.DataBoundItem;

                Booking newBooking = new Booking()
                {
                    DateBooked = DateTime.Now.Date,
                    DateFrom = dtpBookingFrom.Value.Date,
                    DateTo = dtpBookingTo.Value.Date,
                    Customers = _bookingCustomer,
                    Price = 1000 * (dtpBookingTo.Value.Date - dtpBookingFrom.Value.Date).Days,
                    Room = selectedRoom
                };
                Program.Db.Bookings.Add(newBooking);

                for (int i = selectedRoom.Beds; i < people; i++)
                {
                    BookExtrabed(newBooking);
                }
            }


            Program.Db.SaveChanges();
            UpdateDatagrids();
            MessageBox.Show("Successfully booked room");
        }

        private void BookExtrabed(Booking booking)
        {
            Program.Db.ExtrabedBookings.Add(new ExtrabedBooking()
            {
                Bookings = booking,
                Extrabed = GetAvailableExtraBeds().FirstOrDefault()
            }
            );
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateDatagrids();
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateDatagrids();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDatagrids();
        }

        private void btnBookingCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBookingBook_Click(object sender, EventArgs e)
        {
            BookSelectedRoom();
        }

    }
}
