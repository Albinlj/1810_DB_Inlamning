using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Hotel
{
    public partial class frmViewBookings : Form
    {
        public frmViewBookings()
        {
            InitializeComponent();
            dgBookings.DataSource = Program.Db.Bookings.Local.ToBindingList();
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            Booking bookingToDelete = GetSelectedBooking();
            if (bookingToDelete != null)
            {
                Customer customerOfBooking = bookingToDelete.Customers;
                DeleteBookingAndBedBookings(bookingToDelete);
                new frmNewBooking(customerOfBooking).ShowDialog();
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            Booking bookingToDelete = GetSelectedBooking();
            if (bookingToDelete != null)
            {
                DeleteBookingAndBedBookings(bookingToDelete);
            }
        }

        private void DeleteBookingAndBedBookings(Booking bookingToDelete)
        {
            Program.Db.ExtrabedBookings.RemoveRange(bookingToDelete.ExtrabedBooking);
            Program.Db.Bookings.Remove(bookingToDelete);
            Program.Db.SaveChanges();
        }

        private Booking GetSelectedBooking()
        {
            if (dgBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("No booking selected.");
                return null;
            }
            else if (dgBookings.SelectedRows.Count > 1)
            {

                MessageBox.Show("Please select only one booking.");
                return null;
            }
            else
            {
                return dgBookings.SelectedRows[0].DataBoundItem as Booking;
            }
        }


        private void btnRegisterPayment_Click(object sender, EventArgs e)
        {
            Booking booking = GetSelectedBooking();
            if (booking != null)
            {
                if (booking.Payments == null)
                {

                    new FrmAddPayment(booking);
                }
                else
                {
                    MessageBox.Show("This booking already has a payment registered.");
                }
            }
        }
    }
}
