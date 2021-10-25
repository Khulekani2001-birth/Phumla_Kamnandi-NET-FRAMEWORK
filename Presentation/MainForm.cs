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

       
    }
}
