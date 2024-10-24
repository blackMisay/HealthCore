namespace Core.Data
{
    public class Surgery
    {
		private int id;
        private string description = "";
        private DateTime surgeryDate;
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

		public DateTime SurgeryDate
		{
			get { return surgeryDate; }
			set { surgeryDate = value; }
		}

		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}
	}
}
