using System.Globalization;

namespace Core.Data
{
    public class Patient
    {
        private int id;
        private string firstName = "";
        private string middleName = "";
        private string lastName = "";
        private DateTime birthDate;
        private int age;
        private Gender gender;
        private CivilStatus civilStatus;
        private byte mobileNumber;
        private string address = "";
        private string guardianName = "";
        private string guardianOccupation = "";

        List<MedicalHistory>? PatientMedicalHistory;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = SetProperCase(value); }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = SetProperCase(value); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = SetProperCase(value); }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public int Age
        {
            get { return age; }
            private set 
            {
                DateTime today = DateTime.Today;
                int tempAge = today.Year - birthDate.Year;

                // Check if the birthday has occurred this year
                if (birthDate > today.AddYears(-tempAge))
                {
                    tempAge--;
                }

                age = tempAge;
            }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public CivilStatus CivilStatus
        {
            get { return CivilStatus; }
            set { civilStatus = value; }
        }

        public byte MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = SetProperCase(value); }
        }

        public string GuardianName
        {
            get { return guardianName; }
            set { guardianName = SetProperCase(value); }
        }

        public string GuardianOccupation
        {
            get { return guardianOccupation; }
            set { guardianOccupation = SetProperCase(value); }
        }

        
        public string GetFullName(bool isMiddleInitial)
        {
            return isMiddleInitial ? 
                   this.FirstName + " " + GetInitials(this.MiddleName) + " " + this.LastName : 
                   this.FirstName + " " + this.MiddleName +  " " + this.LastName;
        }

        private static string GetInitials(string name)
        {
            // StringSplitOptions.RemoveEmptyEntries excludes empty spaces returned by the Split method

            string[] nameSplit = name.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            string initials = "";

            foreach (string item in nameSplit)
            {
                initials += item.Substring(0, 1).ToUpper() + ".";
            }

            return initials;
        }

        TextInfo textWriter = new CultureInfo("en-US", false).TextInfo;
        public string SetProperCase(string text)
        {
            return textWriter.ToTitleCase(text.ToLower());
        }
    }
}