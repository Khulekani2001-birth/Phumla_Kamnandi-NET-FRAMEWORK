using System;
using System.Collections.Generic;
using System.Text;

namespace Phumla_Kamnandi.Business
{
	class Guest
	{
		#region Data Members
		private String id;
		private String name;
		private String surname;
		private String address;
		#endregion

		#region Constructor
		public Guest(String ID, String name, String surname, String address)
		{
			this.id = ID;
			this.name = name;
			this.surname = surname;
			this.address = address;
		}

		public Guest()
		{
			this.id = "";
			this.name = "";
			this.surname = "";
			this.address = "";
		}
		#endregion

		public String ID
		{
			get { return id; }
			set { id = value; }
		}

		public String Name
		{
			get { return name; }
			set { name = value; }
		}

		public String Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		public String Address
		{
			get { return address; }
			set { address = value; }
		}

		public override String ToString()
		{
			return "Guest ID: " + ID + "\nName and Surname: " + name + " " + surname + "\nAddress: " + address;
		}



	}
}