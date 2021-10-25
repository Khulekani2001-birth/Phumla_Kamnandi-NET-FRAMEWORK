using System;
using System.Collections.Generic;
using System.Text;

namespace Phumla_Kamnandi.Business
{
    public class Booking
    {
        #region Variables

        private string id;
        private string guestID;
        private int roomNo;
        private DateTime date;
        private decimal price;
        private bool deposit; 
        #endregion

        #region Properties 
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public int RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        #endregion

        #region Utility method
        public decimal calculatePrice(DateTime bookDate)
        {
            decimal price = 0;
            switch (bookDate.Date.Day)
            {
                case int n when (n <= 7):
                    price = 605;
                    break;
                case int n when (n >= 8 && n <= 15):
                    price = 825;
                    break;
                case int n when (n > 15):
                    price = 1094.5m;
                    break;
            }
            return price;
        }
        #endregion

        #region constructor

        public Booking(string id, string guestID, int roomNo, DateTime date, decimal price, bool deposit)
        {
            this.id = id;
            this.guestID = guestID;
            this.roomNo = roomNo;
            this.date = date;
            this.price = price;
            this.deposit = deposit;

        }

        public Booking()
        {
            id = "";
            guestID = "";
            roomNo = 0;
            date = DateTime.MinValue;
            price = 0;
            deposit = false;
        }

        #endregion
    }
}