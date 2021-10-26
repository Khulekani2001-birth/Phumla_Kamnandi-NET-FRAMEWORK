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
    public partial class MainForm : Form
    {
        #region Variables
        ChangeBookingForm changeBookingForm;
        CancelBookingForm cancelBookingForm;
        BookingListingForm bookingListingForm;
        CreateBookingForm createBookingForm;
        CreateGuestForm createGuestForm;
        BookingController bookingController;
        GuestController guestController;
        //for availability
        Collection<Booking> bookings;
        #endregion


        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            bookingController = new BookingController();
            guestController = new GuestController();
        }
        #endregion
 
        # region Form events
        private void changeBookingButton_Click(object sender, EventArgs e)
        {
            if (changeBookingForm == null)
            {
                CreateChangeBookingListingForm();
            }
            if (changeBookingForm.changeListFormClosed)
            {
                CreateChangeBookingListingForm();
            }

            changeBookingForm.setUpChangeBookingListingForm();

            changeBookingForm.Show();
        }

        private void cancelBookingButton_Click(object sender, EventArgs e)
        {
            if (cancelBookingForm == null)
            {
                CreateCancelBookingListingForm();
            }
            if (cancelBookingForm.cancelListFormClosed)
            {
                CreateCancelBookingListingForm();
            }

            cancelBookingForm.setUpCancelBookingForm();

            cancelBookingForm.Show();
        }

        private void listBookingsButton_Click(object sender, EventArgs e)
        {
            if (bookingListingForm == null)
            {
                CreateBookingListingForm();
            }
            if (bookingListingForm.bookingListFormClosed)
            {
                CreateBookingListingForm();
            }

            bookingListingForm.setUpBookingListingForm();

            bookingListingForm.Show();
        }

        private void newBookingButton_Click(object sender, EventArgs e)
        {
            if (createBookingForm == null)
            {
                CreateCreateBookingListingForm();
            }
            if (createBookingForm.createFormClosed)
            {
                CreateCreateBookingListingForm();
            }

            createBookingForm.Show();
        }

        private void newGuestButton_Click(object sender, EventArgs e)
        {
            if (createGuestForm == null || createGuestForm.IsDisposed)
            {
                CreateCreateGuestForm();
            }
            if (createGuestForm.createFormClosed)
            {
                CreateCreateGuestForm();
            }

            createGuestForm.Show(); 
        }

        private void checkAvailabilityLabel_Click(object sender, EventArgs e)
        {
            setUpAvalabilityListViewListingForm();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AvalabilityListView.Clear();
        }

        #endregion

        #region Child Forms
        private void CreateBookingListingForm()
        {
            bookingListingForm = new BookingListingForm(bookingController);
            bookingListingForm.StartPosition = FormStartPosition.CenterParent;
            //this.Hide();
        }

        private void CreateCancelBookingListingForm()
        {
            cancelBookingForm = new CancelBookingForm(bookingController);
            cancelBookingForm.StartPosition = FormStartPosition.CenterParent;
            //this.Hide();
        }

        private void CreateChangeBookingListingForm()
        {
            changeBookingForm = new ChangeBookingForm(bookingController);
            changeBookingForm.StartPosition = FormStartPosition.CenterParent;
            //this.Hide();
        }
        
        private void CreateCreateBookingListingForm()
        {
            createBookingForm = new CreateBookingForm(bookingController);
            createBookingForm.StartPosition = FormStartPosition.CenterParent;
            //this.Hide();
        }

        private void CreateCreateGuestForm()
        {
            createGuestForm = new CreateGuestForm(guestController);
            createGuestForm.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        #region List View SetUp
        public void setUpAvalabilityListViewListingForm()
        {
            ListViewItem AvalabilityListViewDetails;
            AvalabilityListView.Clear();

            bookings = bookingController.allBookings;

            AvalabilityListView.Columns.Insert(0, "Date", 120, HorizontalAlignment.Left);
            AvalabilityListView.Columns.Insert(1, "Price", 120, HorizontalAlignment.Left);
            AvalabilityListView.Columns.Insert(2, "status", 120, HorizontalAlignment.Left);

            int count = 0; //for counting the number iterations
            int size = bookings.Count;

            foreach (Booking booking in bookings)
            {
                AvalabilityListViewDetails = new ListViewItem();
                count++;

                if (availabledateTimePicker.Value == booking.Date)
                {

                    AvalabilityListViewDetails.Text = booking.Date.ToString();
                    AvalabilityListViewDetails.SubItems.Add(booking.Price.ToString());
                    AvalabilityListViewDetails.SubItems.Add(count.ToString());

                    AvalabilityListView.Items.Add(AvalabilityListViewDetails);
                    
                }
               if (AvalabilityListView.Items.Count == 0 && count ==size)   //checking if there are values if listview after all possible additions
                {
                    decimal price = booking.calculatePrice(availabledateTimePicker.Value);

                    AvalabilityListViewDetails.Text = availabledateTimePicker.Value.ToString();
                    AvalabilityListViewDetails.SubItems.Add(price.ToString());
                    AvalabilityListViewDetails.SubItems.Add("All rooms are Available");

                    AvalabilityListView.Items.Add(AvalabilityListViewDetails);
                }
            }
            
            AvalabilityListView.Refresh();
            AvalabilityListView.GridLines = true;

        }

        #endregion

    }
}
