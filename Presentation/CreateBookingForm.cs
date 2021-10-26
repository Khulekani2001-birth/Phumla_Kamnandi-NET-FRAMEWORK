using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi.Business;

namespace Phumla_Kamnandi.Presentation
{
    public partial class CreateBookingForm : Form
    {
        #region Variables
        public bool createFormClosed = false;
        private Booking booking;
        private BookingController bookingController;
        #endregion

        #region Constructor
        public CreateBookingForm(BookingController bControlller)
        {
            InitializeComponent();
            bookingController = bControlller;
            this.Load += CreateBookingListingForm_Load;
            this.Activated += CreateBookingListingForm_Activated;
            this.FormClosed += CreateBookingListingForm_FormClosed;
        }
        #endregion

        #region Utility Methods
        private void ShowAll()
        {
            iDTextBox.Visible = true;
            guestIDTextBox.Visible = true;
            pickDateTimePicker.Visible = true;

            IDLabel.Visible = true;
            guestIDLabel.Visible = true;
            dateLabel.Visible = true;
        }

        private void ClearAll()
        {
            iDTextBox.Text = "";
            guestIDTextBox.Text = "";
            pickDateTimePicker.ResetText();
        }

        private void PopulateObject()
        {
            booking = new Booking();
            booking.ID = iDTextBox.Text;
            booking.GuestID = guestIDTextBox.Text;
            booking.Date = pickDateTimePicker.Value;
            booking.Price = booking.calculatePrice(pickDateTimePicker.Value);
            booking.RoomNo = 0;
            booking.Deposit = true;
        }
        #endregion

        #region Form events
        private void CreateBookingListingForm_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void CreateBookingListingForm_Activated(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void CreateBookingListingForm_FormClosed(object sender, EventArgs e)
        {
            createFormClosed = true;
        }

        private void CreateBookingForm_Load(object sender, EventArgs e)
        {
            ShowAll();
        }
        #endregion

        #region Buttons
        private void enterButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            MessageBox.Show("To be submitted to the Database!");
            bookingController.DataMaintenance(booking, Data.DB.DBOperation.Add);
            bookingController.FinalizeChanges(booking);
            ClearAll();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            createFormClosed = true;
            this.Close();
        }

        #endregion

    }
}
