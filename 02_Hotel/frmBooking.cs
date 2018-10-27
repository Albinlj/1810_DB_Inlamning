using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Hotel
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
            cbBookingPeople.SelectedIndex = 0;
            dgBookingRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateDatagrid();
        }

        private bool IsOverlapping(DateTime aStart, DateTime aEnd, DateTime bStart, DateTime bEnd)
        {
            return (aStart < bEnd && bStart < aEnd);
        }


        private void UpdateDatagrid()
        {
            dgBookings.DataSource = Program.Db.Bookings.Local.ToBindingList();


            //int AvailableExtraBeds 
            int People = int.Parse(cbBookingPeople.SelectedItem.ToString());
            //dgBookingRooms.DataSource = Program.Db.Rooms.Local.Where(x => x.Beds >= People).ToList();o
            var RoomsWithOverlappingBookings = (from room in Program.Db.Rooms.ToList()
                                                join booking in Program.Db.Bookings.ToList()
                                                on room equals booking.Room
                                                where IsOverlapping(booking.DateFrom, booking.DateTo, dtpBookingFrom.Value, dtpBookingTo.Value)
                                                select room).ToList();

            dgBookingRooms.DataSource = (from r in Program.Db.Rooms.ToList()
                                         where r.Beds >= People && !RoomsWithOverlappingBookings.Contains(r)
                                         select r).ToList();
        }

        private void BookSelectedRoom()
        {
            Room selectedRoom = (Room)dgBookingRooms.CurrentRow.DataBoundItem;
            if ((dtpBookingTo.Value.Date - dtpBookingFrom.Value.Date).Days > 0)
            {
                Program.Db.Bookings.Add(new Booking()
                {
                    DateBooked = DateTime.Now.Date,
                    DateFrom = dtpBookingFrom.Value.Date,
                    DateTo = dtpBookingTo.Value.Date,
                    Customers = Program.Db.Customers.FirstOrDefault(),
                    Price = 1000m,
                    Room = selectedRoom
                });
            }

            Program.Db.SaveChanges();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
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
