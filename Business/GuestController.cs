using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Phumla_Kamnandi.Data;

namespace Phumla_Kamnandi.Business
{
    public class GuestController
    {
        #region Data Members
        private BookingDB guestDB;
        private Collection<Guest> guests;
        #endregion

        #region Properties
        public Collection<Guest> allGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region Constructor
        public GuestController()
        {
            guestDB = new BookingDB();
            guests = guestDB.AllGuests;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Guest aGuest, DB.DBOperation operation)
        {
            guestDB.DataSetChange(aGuest, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    guests.Add(aGuest);
                    break;
            }
        }

        public bool FinalizeChanges(Guest guest)
        {
            return guestDB.UpdateDataSource(guest);
        }
        #endregion
    }
}
