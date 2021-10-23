using System;
using System.Collections.Generic;
using System.Text;

namespace Phumla_Kamnandi.Business
{
    class Room
    {
        #region Data Members
        private int roomNo;
        private enum Type
        {
            Single
        }
        Type roomType;
        #endregion

        #region Constructor
        public Room(int roomNo)
        {
            this.roomNo = roomNo;
            roomType = Type.Single;
        }
        #endregion

        #region NAme?
        public int RoomNo
        {
            get { return roomNo; }
        }

        public override String ToString()
        {
            return "Room " + roomNo + " is a " + roomType + " room.";
        }
        #endregion
    }
}