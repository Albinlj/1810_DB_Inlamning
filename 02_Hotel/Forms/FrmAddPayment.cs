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
    public partial class FrmAddPayment : Form
    {
        private Booking _booking;
        private decimal _amount;
        public FrmAddPayment(Booking booking)
        {
            _booking = booking;
            tbAmount.Text = booking.Price.ToString();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_amount != _booking.Price)
            {
                MessageBox.Show($"You entered a payment of {_amount}, but the booking has a price of {_booking.Price}. Try again.");
            }
            else
            {
                Payment newPayment = new Payment()
                {
                    Amount = _amount,
                    DatePaid = dtpDatePaid.Value
                };
                _booking.Payments = newPayment;
                Program.Db.Payments.Add(newPayment);
                Program.Db.SaveChanges();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbAmount.Text, out _amount))
            {
                btnAddPayment.Enabled = true;
            }
            btnAddPayment.Enabled = false;
        }
    }
}
