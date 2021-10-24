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
    public partial class BookingListingForm : Form
    {
        #region Variables
        public bool bookingListFormClosed;
        private Collection<Booking> bookings;
        private Booking booking;
        private BookingController bookingController;
        #endregion

        #region Constructor
        public BookingListingForm(BookingController bControlller)
        {
            InitializeComponent();
            bookingController = bControlller;
            this.Load += BookingListingForm_Load;
            this.Activated += BookingListingForm_Activated;
            this.FormClosed += BookingListingForm_FormClosed;
        }

        #endregion

        #region Utility Method

        private void ShowAll(bool value)
        {
            IDTextbox.Visible = value;
            guestIDTextBox.Visible = value;
            depositTextBox.Visible = value;
            priceTextBox.Visible = value;
            dateTextBox.Visible = value;
            roomNoTextBox.Visible = value;
            DisableEntries();

            IDLabel.Visible = value;
            guestIDLabel.Visible = value;
            depositLabel.Visible = value;
            roomNoLabel.Visible = value;
            dateLabel.Visible = value;
            priceLabel.Visible = value;
        }

        private void queryBookingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);

            if (queryBookingListView.SelectedItems.Count > 0) //if you select an Item
            {
                booking = bookingController.Find(queryBookingListView.SelectedItems[0].Text);
            }
            populateTextBoxes(booking);
        }

        private void populateTextBoxes(Booking booking)
        {
            IDTextbox.Text = booking.ID;
            guestIDTextBox.Text = booking.GuestID;
            depositTextBox.Text = booking.Deposit.ToString();
            roomNoTextBox.Text = booking.RoomNo.ToString();
            dateTextBox.Text = booking.Date.ToString();
            priceTextBox.Text = booking.Price.ToString();
        }

        private void ClearAll()
        {
            IDTextbox.Text = "";
            guestIDTextBox.Text = "";
            depositTextBox.Text = "";
            priceTextBox.Text = "";
            dateTextBox.Text = "";
            roomNoTextBox.Text = "";
        }

        private void DisableEntries()    
        {
            IDTextbox.Enabled = false;
            guestIDTextBox.Enabled = false;
            depositTextBox.Enabled = false;
            priceTextBox.Enabled = false;
            dateTextBox.Enabled = false;
            roomNoTextBox.Enabled = false;
        }

        #endregion

        #region Events
        private void BookingListingForm_Load(object sender, EventArgs e)
        {
            queryBookingListView.View = View.Details;
        }

        private void BookingListingForm_Activated(object sender, EventArgs e)
        {
            queryBookingListView.View = View.Details;
            setUpBookingListingForm();
            ShowAll(false);
            DisableEntries();
        }

        private void BookingListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookingListFormClosed = true;
        }
        #endregion

        #region List View SetUp
        public void setUpBookingListingForm()
        {
            ListViewItem QueryBookingDetails;
            queryBookingListView.Clear();
            bookings = bookingController.allBookings;

            queryBookingListView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            queryBookingListView.Columns.Insert(1, "GuestID", 120, HorizontalAlignment.Left);
            queryBookingListView.Columns.Insert(2, "RoomNo", 120, HorizontalAlignment.Left);
            queryBookingListView.Columns.Insert(3, "Date", 120, HorizontalAlignment.Left);
            queryBookingListView.Columns.Insert(4, "Price", 120, HorizontalAlignment.Left);
            queryBookingListView.Columns.Insert(5, "depositPaid", 120, HorizontalAlignment.Left);


            foreach (Booking booking in bookings)
            {
                QueryBookingDetails = new ListViewItem();
                QueryBookingDetails.Text = booking.ID.ToString();
                QueryBookingDetails.SubItems.Add(booking.GuestID.ToString());
                QueryBookingDetails.SubItems.Add(booking.RoomNo.ToString());
                QueryBookingDetails.SubItems.Add(booking.Date.ToString());
                QueryBookingDetails.SubItems.Add(booking.Price.ToString());
                QueryBookingDetails.SubItems.Add(booking.Deposit.ToString());


                queryBookingListView.Items.Add(QueryBookingDetails);
            }
            queryBookingListView.Refresh();
            queryBookingListView.GridLines = true;

        }

        #endregion

        #region Buttons
        private void exitButton_Click(object sender, EventArgs e)
        {
            bookingListFormClosed = true;
        }
        #endregion

    }
}
