using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi.Data;
using System.Collections.ObjectModel;

namespace Phumla_Kamnandi.Business
{
    public class BookingController
    {
        #region Data Members
        private BookingDB bookingDB;
        private Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> allBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Booking aBooking, DB.DBOperation operation)
        {
            int index = 0;

            bookingDB.DataSetChange(aBooking, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    bookings.Add(aBooking);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aBooking);
                    bookings[index] = aBooking;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aBooking);
                    bookings.Remove(bookings[index]);
                    break;
            }


        }

        public bool FinalizeChanges(Booking booking)
        {
            return bookingDB.UpdateDataSource(booking);
        }
        #endregion

        #region Searching through a collection
        /*public Collection<Booking> FindByRole(Collection<Booking> booking)  MAYBE CHANGE TO FIND BY DATE??
        {
            Collection<Booking> matches = new Collection<Booking>();
            foreach (Booking booking in bookings)
            {
                if (emp.role.getRoleValue == roleVal)
                {
                    matches.Add(booking);
                }
            }
            return matches;
        }*/

        public Booking Find(string ID)
        {
            int index = 0;
            bool found = (bookings[index].ID == ID);  
            int count = bookings.Count;
            while (!(found) && (index < bookings.Count - 1))  
            {
                index = index + 1;
                found = (bookings[index].ID == ID);
            }
            return bookings[index];   
        }

        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = false;
            found = (aBooking.ID == bookings[counter].ID);
            while (!found && counter < bookings.Count)
            {
                counter++;
                found = (aBooking.ID == bookings[counter].ID);
            }

            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
