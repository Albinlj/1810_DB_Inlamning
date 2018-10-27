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
            dgCustomers.DataSource = Program.Db.Customers.Local.ToBindingList();
            RefreshTheShiet();
        }

        private void RefreshTheShiet()
        {
            lbRooms.Items.Clear();
            lbCustomers.Items.Clear();
            foreach (var dbRoom in Program.Db.Rooms)
            {
                lbRooms.Items.Add(dbRoom);
            }
            foreach (var dbCustomer in Program.Db.Customers)
            {
                lbCustomers.Items.Add(dbCustomer);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmCreateCustomer("yo").ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void dgCustomers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTheShiet();
            Program.Db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmBooking().ShowDialog();
        }
    }
}
