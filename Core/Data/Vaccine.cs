using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class Vaccine
    {
		private int id;
        private string description = "";
        private DateTime vaccinationDate;
        private string remarks = "";

        public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public DateTime VaccinationDate
		{
			get { return vaccinationDate; }
			set { vaccinationDate = value; }
		}

		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

	}
}
