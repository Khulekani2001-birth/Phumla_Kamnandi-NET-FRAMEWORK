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
    public partial class BookingsMDIParent : Form
    {
        #region Variables
        ChangeBookingForm changeBookingForm;
        CancelBookingForm cancelBookingForm;
        BookingListingForm bookingListingForm;
        CreateBookingForm createBookingForm;
        CreateGuestForm createGuestForm;
        BookingController bookingController;
        #endregion

        #region Constructor
        public BookingsMDIParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            bookingController = new BookingController();
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

            cancelBookingForm.setUpCancelBookingListingForm();

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
            createBookingForm = new CreateBookingForm(bookingController);
            createBookingForm.MdiParent = this;
            createBookingForm.StartPosition = FormStartPosition.CenterParent;
        }
        #endregion

        #region Child Forms
        private void CreateBookingListingForm()
        {
            bookingListingForm = new BookingListingForm(bookingController);
            bookingListingForm.MdiParent = this;
            bookingListingForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateCancelBookingListingForm()
        {
            cancelBookingForm = new CancelBookingForm(bookingController);
            cancelBookingForm.MdiParent = this;
            cancelBookingForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateChangeBookingListingForm()
        {
            changeBookingForm = new ChangeBookingForm(bookingController);
            changeBookingForm.MdiParent = this;
            changeBookingForm.StartPosition = FormStartPosition.CenterParent;
        }
        #endregion


    }
}
