using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Phumla_Kamnandi.Business;
using System.Text;

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
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Guest guest;
            Booking booking;

            if (table == "Guest")
            {
                foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                {
                    myRow = myRow_loopVariable;
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        guest = new Guest();

                        guest.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                        guest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                        guest.Surname = Convert.ToString(myRow["Surname"]).TrimEnd();
                        guest.Address = Convert.ToString(myRow["Address"]).TrimEnd();

                    }
                    guests.Add(guest);
                }
            }
            else if (table == "Booking")
            {
                foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                {
                    myRow = myRow_loopVariable;
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        booking = new Booking();

                        booking.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                        booking.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                        booking.RoomNo = Convert.ToString(myRow["RoomNo"]).TrimEnd();
                        booking.Date = Convert.ToString(myRow["Date"]).TrimEnd();
                        booking.Price = Convert.ToString(myRow["Price"]).TrimEnd();

                    }
                    bookings.Add(booking);
                }
            }

        }

        private void FillRow(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["ID"] = booking.ID;
                aRow["GuestID"] = booking.GuestID;
            }
            aRow["RoomNo"] = booking.RoomNo;//We still need to discuss if room number can be changed
            aRow["Date"] = booking.Date;
            aRow["Price"] = booking.Price;
        }

        private void FillRow(DataRow aRow, Guest guest, DB.DBOperation operation)
        {
            //if (operation == DB.DBOperation.Add) //The only operation that can be done anyway is only add
            aRow["ID"] = guest.ID;
            aRow["Name"] = guest.Name;
            aRow["Address"] = guest.Address;
            aRow["Surname"] = guest.Surname;
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
                    if (booking.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
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
            break;
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking booking)
        {
            //WE'LL HAVE TO ADJUST ACCORDING TO DATABASE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNo", SqlDbType.TinyInt, 100, "RoomNo");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Date", SqlDbType.Date, 15, "Date");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Decimal, 1, "Price");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Build_INSERT_Parameters(Guest guest)
        {
            //WE'LL HAVE TO ADJUST ACCORDING TO DATABASE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 10, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 100, "Surname");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Create_INSERT_Command(Booking booking)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Bookings (ID, GuestID, RoomNo, Date, Price) VALUES (@ID, @GuestID, @RoomNo, @Date, @Price)", cnMain);

            Build_INSERT_Parameters(booking);
        }
        private void Create_INSERT_Command(Guest guest)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Guests (ID, Name, Surname, Address) VALUES (@ID, @Name, @Surname, @Address)", cnMain);

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
            //Create_UPDATE_Command(booking);
            //Create_DELETE_Command(booking);

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
        }

        private void Create_UPDATE_Command(Booking booking)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Bookings SET ID =@ID,GuestID =@GuestID, RoomNo = @RoomNo, Date =@Date, Price =@Price " + "WHERE ID = @ID", cnMain);

            Build_UPDATE_Parameters(booking);
        }

        private void Build_DELETE_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ID", SqlDbType.NVarChar, 100, "ID");
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
        }

        private void Create_DELETE_Command(Booking booking)
        {                               //NOT SURE IF THIS IS RIGHT
            daMain.DeleteCommand = new SqlCommand("DELETE Booking SET ID =@ID,GuestID =@GuestID, RoomNo = @RoomNo, Date =@Date, Price =@Price " + "WHERE ID = @ID", cnMain);

            Build_DELETE_Parameters(booking);
        }
        #endregion
    }
}