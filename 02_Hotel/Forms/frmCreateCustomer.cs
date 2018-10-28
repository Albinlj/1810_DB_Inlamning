using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Hotel
{
    public partial class frmCreateCustomer : Form
    {
        public frmCreateCustomer()
        {
            InitializeComponent();
        }



        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            newCustomer.FirstName = tbFirstName.Text;
            newCustomer.LastName = tbLastName.Text;
            newCustomer.Address = tbAddress.Text;
            newCustomer.City = tbCity.Text;
            newCustomer.PostalCode = tbPostalCode.Text;
            newCustomer.Country = tbCountry.Text;

            Program.Db.Customers.Add(newCustomer);
            Program.Db.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
