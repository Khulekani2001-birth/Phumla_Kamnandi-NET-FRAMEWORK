using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Phumla_Kamnandi.Business;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Phumla_Kamnandi.Data
{
    class BookingDB : DB
    {
        #region  Data members        
        private string table1 = "Bookings";
        private string sqlLocal1 = "SELECT * FROM Bookings";
        private string table2 = "Guests";
        private string sqlLocal2 = "SELECT * FROM Guests";

        private Collection<Booking> bookings;
        private Collection<Guest> guests;
        #endregion

        #region Property Method: Collections
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }

        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Guest guest;
            Booking booking;

            if (table == "Guests")
            {
                foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                {
                    myRow = myRow_loopVariable;
                    guest = new Guest();
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        guest.ID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                        guest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                        guest.Surname = Convert.ToString(myRow["Surname"]).TrimEnd();
                        guest.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                        guest.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();

                    }
                    guests.Add(guest);
                }
            }
            else if (table == "Bookings")
            {
                foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                {
                    myRow = myRow_loopVariable;
                    booking = new Booking();
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        booking.ID = Convert.ToString(myRow["BookingID"]).TrimEnd();
                        booking.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                        if (myRow["RoomNo"] is DBNull)
                        {
                            booking.RoomNo = Convert.ToInt32(0);
                        }
                        else
                        {
                            booking.RoomNo = Convert.ToInt32(myRow["RoomNo"]);
                        }

                        booking.Date = Convert.ToDateTime(myRow["Date"]);
                        booking.Price = Convert.ToDecimal(myRow["Price"]);
                        booking.Deposit = Convert.ToBoolean(myRow["depositPaid"]);

                    }
                    bookings.Add(booking);
                }
            }

        }

        private void FillRow(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["BookingID"] = booking.ID;
                aRow["GuestID"] = Convert.ToInt32(booking.GuestID);
                aRow["RoomNo"] = booking.RoomNo;
                aRow["Date"] = booking.Date;
                aRow["Price"] = booking.Price;
                aRow["depositPaid"] = booking.Deposit.ToString();
            }
        }

        private void FillRow(DataRow aRow, Guest guest, DB.DBOperation operation)
        {
            aRow["ID"] = guest.ID;
            aRow["Name"] = guest.Name;
            aRow["Address"] = guest.Address;
            aRow["Surname"] = guest.Surname;
            aRow["Phone"] = guest.Phone;
        }

        private int FindRow(Booking booking, String table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (booking.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }

        private int FindRow(Guest guest, String table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (guest.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Booking booking, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, booking, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(booking, dataTable)];
                    //aRow.Delete();
                    dsMain.Tables[dataTable].Rows.Remove(aRow);
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(booking, dataTable)];
                    FillRow(aRow, booking, operation);
                    break;
            }
        }

        public void DataSetChange(Guest guest, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table2;

            //switch (operation)
            //case DB.DBOperation.Add:  WE CAN ONLY ADD GUESTS

            aRow = dsMain.Tables[dataTable].NewRow();
            FillRow(aRow, guest, operation);
            dsMain.Tables[dataTable].Rows.Add(aRow);
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, booking.ID);
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.TinyInt, 10, booking.GuestID);
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNo", SqlDbType.TinyInt, 10, Convert.ToString(booking.RoomNo));
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Date", SqlDbType.Date, 15, Convert.ToString(booking.Date));
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Decimal, 1, Convert.ToString(booking.Price));
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@depositPaid", SqlDbType.NVarChar, 10, Convert.ToString(booking.Deposit));
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_INSERT_Parameters(Guest guest)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, guest.ID);
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 10, guest.Name);
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 100, guest.Surname);
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, guest.Address);
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, guest.Phone);
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Booking booking)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO Bookings ("+ booking.ID.ToString() +", "+ Convert.ToInt32(booking.GuestID) +", "+ Convert.ToInt32(booking.RoomNo) +", " + booking.Date + ", " + booking.Price.ToString() + ", " + booking.Deposit.ToString() + ") VALUES (@BookingID, @GuestID, @RoomNo, @Date, @Price, @depositPaid)", cnMain);

            Build_INSERT_Parameters(booking);
        }
        private void Create_INSERT_Command(Guest guest)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Guests ("+guest.ID+","+ guest.Name+","+ guest.Surname+","+ guest.Address+","+ guest.Phone+") VALUES (@GuestID, @Name, @Surname, @Address, @Phone)", cnMain);

            Build_INSERT_Parameters(guest);
        }

        public bool UpdateDataSource(Booking booking)
        {
            bool success = true;
            Create_INSERT_Command(booking);
            Create_UPDATE_Command(booking);
            Create_DELETE_Command(booking);

            success = UpdateDataSource(sqlLocal1, table1);

            return success;
        }
        public bool UpdateDataSource(Guest guest)
        {
            bool success = true;
            Create_INSERT_Command(guest);

            success = UpdateDataSource(sqlLocal2, table2);

            return success;
        }

        private void Build_UPDATE_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ID", SqlDbType.NVarChar, 100, "ID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNo", SqlDbType.TinyInt, 1, "RoomNo");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Date", SqlDbType.NVarChar, 15, "Date");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Money, 8, "Price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@depositPaid", SqlDbType.Money, 8, "depositPaid");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Booking booking)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Bookings SET ID =@ID,GuestID =@GuestID, RoomNo = @RoomNo, Date =@Date, Price =@Price, depositPaid =@depositPaid " + "WHERE BookingID = @BookingID", cnMain);

            Build_UPDATE_Parameters(booking);
        }

        private void Build_DELETE_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 100, "BookingID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNo", SqlDbType.NVarChar, 15, "RoomNo");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@Date", SqlDbType.TinyInt, 1, "Date");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Money, 8, "Price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@depositPaid", SqlDbType.NVarChar, 10, "depositPaid");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_DELETE_Command(Booking booking)
        {                               
            daMain.DeleteCommand = new SqlCommand("DELETE Booking SET BookingID =@BookingID,GuestID =@GuestID, RoomNo = @RoomNo, Date =@Date, Price =@Price, depositPaid =@depositPaid " + "WHERE BookingID = @BookingID", cnMain);

            Build_DELETE_Parameters(booking);
        }
        #endregion
    }
}