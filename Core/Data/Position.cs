using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class Position
    {
		private int id;
        private string description = "";
        private string specialization = "";

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

		public string Specialization
		{
			get { return specialization; }
			set { specialization = value; }
		}
	}
}
