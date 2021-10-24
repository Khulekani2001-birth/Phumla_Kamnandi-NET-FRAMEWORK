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
using System.Collections.ObjectModel;

namespace Phumla_Kamnandi.Presentation
{
    public partial class ChangeBookingForm : Form
    {
        #region Variables
        public bool changeListFormClosed;
        private Collection<Booking> bookings;
        private Booking booking;
        private BookingController bookingController;
        #endregion

        #region Constructor
        public ChangeBookingForm(BookingController bControlller)
        {
            InitializeComponent();
            bookingController = bControlller;
            this.Load += ChangeBookingListingForm_Load;
            this.Activated += ChangeBookingListingForm_Activated;
            this.FormClosed += ChangeBookingListingForm_FormClosed;
        }

        #endregion

        #region Utility Methods
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
            changeDateTimePicker.Visible = value;
            priceTextBox.Visible = value;

            changeBookingButton.Visible = value;
        }

        private void EnableEntries(bool value)
        {
            changeBookingButton.Enabled = value;

            changeDateTimePicker.Enabled = value;
            IDTextBox.Enabled = false; //cant change
            guestIDTextBox.Enabled = false; //cant change
            depositTextBox.Enabled = value; //??
            priceTextBox.Enabled = false; //cant set themselves
            roomNoTextBox.Enabled = false; //cant set
        }

        private void PopulateObject()
        {
            booking = new Booking();
            booking.ID = IDTextBox.Text;
            booking.GuestID = guestIDTextBox.Text;
            booking.Deposit = false;  //???
            booking.RoomNo = 0;
            booking.Date = changeDateTimePicker.Value;
            booking.Price = booking.calculatePrice(changeDateTimePicker.Value);

        }

        private void ClearAll()
        {
            IDTextBox.Text = "";
            guestIDTextBox.Text = "";
            depositTextBox.Text = "";
            roomNoTextBox.Text = "";
            changeDateTimePicker.Value = changeDateTimePicker.MinDate;
            priceTextBox.Text = "";
        }
        #endregion

        #region Events
        private void ChangeBookingListingForm_Load(object sender, EventArgs e)
        {
            changeBookingListView.View = View.Details;
        }

        private void ChangeBookingListingForm_Activated(object sender, EventArgs e)
        {
            changeBookingListView.View = View.Details;
            setUpChangeBookingListingForm();
            ShowAll(false);
        }

        private void ChangeBookingListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            changeListFormClosed = true;
        }
        #endregion

        #region List View SetUp
        public void setUpChangeBookingListingForm()
        {
            ListViewItem changeBookingDetails;
            changeBookingListView.Clear();

            bookings = bookingController.allBookings;

            changeBookingListView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            changeBookingListView.Columns.Insert(1, "GuestID", 120, HorizontalAlignment.Left);
            changeBookingListView.Columns.Insert(2, "RoomNo", 120, HorizontalAlignment.Left);
            changeBookingListView.Columns.Insert(3, "Date", 120, HorizontalAlignment.Left);
            changeBookingListView.Columns.Insert(4, "Price", 120, HorizontalAlignment.Left);
            changeBookingListView.Columns.Insert(5, "depositPaid", 120, HorizontalAlignment.Left);

            foreach (Booking booking in bookings)
            {
                changeBookingDetails = new ListViewItem();
                changeBookingDetails.Text = booking.ID.ToString();
                changeBookingDetails.SubItems.Add(booking.GuestID.ToString());
                changeBookingDetails.SubItems.Add(booking.RoomNo.ToString());
                changeBookingDetails.SubItems.Add(booking.Date.ToString());
                changeBookingDetails.SubItems.Add(booking.Price.ToString());
                changeBookingDetails.SubItems.Add(booking.Deposit.ToString());

                changeBookingListView.Items.Add(changeBookingDetails);
            }
            changeBookingListView.Refresh();
            changeBookingListView.GridLines = true;

        }

        private void ChangeBookingListView_SelectedIndexChanged(Object seder, EventArgs e)
        {
            ShowAll(true);

            EnableEntries(false);
            if (changeBookingListView.SelectedItems.Count > 0) //if you select an Item
            {
                booking = bookingController.Find(changeBookingListView.SelectedItems[0].Text);
            }
        }

        #endregion

        #region Buttons
        private void editButton_Click(object sender, EventArgs e)
        {
            EnableEntries(true);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            changeListFormClosed = true;
            this.Close();
        }

        private void changeBookingButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            bookingController.DataMaintenance(booking, Data.DB.DBOperation.Edit);
            bookingController.FinalizeChanges(booking);
            ClearAll();

            ShowAll(false);
            setUpChangeBookingListingForm();
        }
        #endregion
    }
}
