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
    public partial class CreateGuestForm : Form
    {
        #region Variables
        public bool createFormClosed = false;
        private Guest guest;
        private GuestController guestController;
        #endregion

        #region Constructor
        public CreateGuestForm(GuestController guestControl)
        {
            InitializeComponent();
            guestController = guestControl;
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            adressTextBox.Visible = value;
            nameTextBox.Visible = value;
            surnameTextBox.Visible = value;
            iDTextBox.Visible = value;

            iDLabel.Visible = value;
            nameLabel.Visible = value;
            surnameLabel.Visible = value;
            addressLabel.Visible = value;
        }

        private void ClearAll()
        {
            adressTextBox.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            iDTextBox.Text = "";
        }

        private void PopulateObject()
        {
            guest = new Guest();
            guest.ID = adressTextBox.Text;
            guest.Name = nameTextBox.Text;
            guest.Surname = surnameTextBox.Text;
            guest.Address = iDTextBox.Text;
        }
        #endregion

        #region Form events
        private void enterButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            MessageBox.Show("To be submitted to the Database!");
            guestController.DataMaintenance(guest, Data.DB.DBOperation.Add);
            guestController.FinalizeChanges(guest);
            ClearAll();
            ShowAll(false);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            createFormClosed = true;
            this.Close();
        }

        private void CreateGuestForm_Load(object sender, EventArgs e)
        {
            ShowAll(false);
        }

        private void CreateGuestForm_Activated(object sender, EventArgs e)
        {
            ShowAll(false);
        }
        #endregion
    }
}
