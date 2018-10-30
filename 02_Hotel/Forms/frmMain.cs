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
using FormStartPosition = System.Windows.Forms.FormStartPosition;

namespace _02_Hotel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Program.Db.Customers.ToList();
            dgCustomers.DataSource = Program.Db.Customers.Local.ToBindingList();

        }


        private Customer GetSelectedCustomer()
        {
            if (dgCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("No customer selected. You need to select an entire row by clicking the leftmost cell of the row.");
                return null;
            }
            else if (dgCustomers.SelectedRows.Count > 1)
            {

                MessageBox.Show("Please select only one customer.");
                return null;
            }
            else
            {
                return (Customer)dgCustomers.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            new frmCreateCustomer().ShowDialog();
        }


        private void dgCustomers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Program.Db.SaveChanges();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            Customer customer = GetSelectedCustomer();
            if (customer != null)
            {
                new frmNewBooking(customer).Show();
            }
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer customerToDelete = GetSelectedCustomer();
            if (customerToDelete != null)
                if (Program.Db.Bookings.ToList().Any(x => x.Customers == customerToDelete))
                {
                    MessageBox.Show("Can not delete this customer because they still have a booking.");
                }
                else
                {
                    Program.Db.Customers.Remove(customerToDelete);
                }
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            new frmViewBookings().Show();
        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
