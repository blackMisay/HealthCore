using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class MedicalQuestion
    {
		private int id;
        private string tag = "";
        private string description = "";
        private bool response;
        private string remarks = "";
        

        public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Tag
		{
			get { return tag; }
			set { tag = value; }
		}

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public bool Response
		{
			get { return response; }
			set { response = value; }
		}

		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}



	}
}
