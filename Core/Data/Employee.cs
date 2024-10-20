using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class Employee
    {
		private int id;
        private string firstName = "";
        private string middleName = "";
        private string lastName = "";
		Position? position;
        private string address = "";
        private byte mobileNumber;
        private byte phoneNumber;
        private string emailAddress = "";

        public int Id
		{
			get { return id; }
			set { id = value; }
		}

        public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

        public string MiddleName
		{
			get { return middleName; }
			set { middleName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

        public string Address
		{
			get { return address; }
			set { address = value; }
		}

        public byte MobileNumber
		{
			get { return mobileNumber; }
			set { mobileNumber = value; }
		}

        public byte PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		public string EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}
	}
}
