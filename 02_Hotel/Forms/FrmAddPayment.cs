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
        private decimal _amountInput;
        public FrmAddPayment(Booking booking)
        {
            _booking = booking;
            InitializeComponent();
            tbAmount.Text = _booking.Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_amountInput != _booking.Price)
            {
                MessageBox.Show($"You entered a payment of {_amountInput}, but the booking has a price of {_booking.Price}. Try again.");
            }
            else
            {
                Payment newPayment = new Payment()
                {
                    Amount = _amountInput,
                    Booking = _booking,
                    DatePaid = dtpDatePaid.Value
                };
                _booking.Payments = newPayment;
                Program.Db.Payments.Add(newPayment);
                try
                {
                    Program.Db.SaveChanges();

                }
                catch (Exception)
                {
                }

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbAmount.Text, out _amountInput))
            {
                btnAddPayment.Enabled = true;
            }
            else
            {
            btnAddPayment.Enabled = false;

            }
        }
    }
}
