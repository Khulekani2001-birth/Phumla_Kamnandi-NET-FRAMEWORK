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
using Phumla_Kamnandi.Data;
using System.Collections.ObjectModel;

namespace Phumla_Kamnandi.Presentation
{
    public partial class CancelBookingForm : Form
    {
        #region Variables
        public bool cancelListFormClosed;
        private Collection<Booking> bookings;
        private Booking booking;
        private BookingController bookingController;
        #endregion

        #region Constructor
        public CancelBookingForm(BookingController bControlller)
        {
            InitializeComponent();
            bookingController = bControlller;
            this.Load += CancelBookingForm_Load;
            this.Activated += CancelBookingForm_Activated;
            this.FormClosed += CancelBookingForm_FormClosed;
        }

        #endregion

        #region Utility Method
        private void populateTextBoxes(Booking booking)
        {
            IDTextBox.Text = booking.ID;
            guestIDTextBox.Text = booking.GuestID;
            depositTextBox.Text = booking.Deposit.ToString();
            roomNoTextBox.Text = booking.RoomNo.ToString();
            dateTextBox.Text = booking.Date.ToString();
            priceTextBox.Text = booking.Price.ToString();
        }

        private void ShowAll(bool value)
        {
            IDLabel.Visible = value;
            guestIDLabel.Visible = value;
            depositLabel.Visible = value;
            roomNoLabel.Visible = value;
            dateLabel.Visible = value;
            priceLabel.Visible = value;

            IDTextBox.Visible = value;
            guestIDTextBox.Visible = value;
            depositTextBox.Visible = value;
            roomNoTextBox.Visible = value;
            dateTextBox.Visible = value;
            priceTextBox.Visible = value;

            cancelBookingButton.Visible = value;
            //exitButton.Visible = value; should always be visible
            //listAllButton.Visible = value;
            //deleteButton.Visible = value; 
        }

        private void DisableEntries()
        {
            IDTextBox.Enabled = false;
            guestIDTextBox.Enabled = false;
            depositTextBox.Enabled = false;
            priceTextBox.Enabled = false;
            dateTextBox.Enabled = false;
            roomNoTextBox.Enabled = false;
        }
        #endregion

        #region Events
        private void CancelBookingForm_Load(object sender, EventArgs e)
        {
            cancelBookingListView.View = View.Details;
        }

        private void CancelBookingForm_Activated(object sender, EventArgs e)
        {
            cancelBookingListView.View = View.Details;
            setUpCancelBookingForm();
            ShowAll(false);
        }

        private void CancelBookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancelListFormClosed = true;
        }

        #endregion

        #region ListViewSetUp

        public void setUpCancelBookingForm()
        {
            ListViewItem cancelBookingDetails;
            bookings = bookingController.allBookings;

            cancelBookingListView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            cancelBookingListView.Columns.Insert(1, "GuestID", 120, HorizontalAlignment.Left);
            cancelBookingListView.Columns.Insert(2, "RoomNo", 120, HorizontalAlignment.Left);
            cancelBookingListView.Columns.Insert(3, "Date", 120, HorizontalAlignment.Left);
            cancelBookingListView.Columns.Insert(4, "Price", 120, HorizontalAlignment.Left);
            cancelBookingListView.Columns.Insert(5, "Deposit", 120, HorizontalAlignment.Left);

            foreach (Booking booking in bookings)
            {
                cancelBookingDetails = new ListViewItem();
                cancelBookingDetails.Text = booking.ID.ToString();
                cancelBookingDetails.SubItems.Add(booking.GuestID.ToString());
                cancelBookingDetails.SubItems.Add(booking.RoomNo.ToString());
                cancelBookingDetails.SubItems.Add(booking.Date.ToString());
                cancelBookingDetails.SubItems.Add(booking.Price.ToString());
                cancelBookingDetails.SubItems.Add(booking.Deposit.ToString());

                cancelBookingListView.Items.Add(cancelBookingDetails);
            }
            cancelBookingListView.Refresh();
            cancelBookingListView.GridLines = true;

        }

        private void CancelBookingListView_SelectedIndexChanged(Object seder, EventArgs e)
        {
            ShowAll(true);
            DisableEntries();
            if (cancelBookingListView.SelectedItems.Count > 0) 
            {
                booking = bookingController.Find(cancelBookingListView.SelectedItems[0].Text);
            }
            populateTextBoxes(booking);
        }
        #endregion

        #region Buttons
        private void cancelBookingButton_Click(object sender, EventArgs e)
        {
            bookingController.DataMaintenance(booking, Data.DB.DBOperation.Delete);
            bookingController.FinalizeChanges(booking);
            ShowAll(false);
            setUpCancelBookingForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            cancelListFormClosed = true;
            this.Close();
        }
        #endregion
    }
}
