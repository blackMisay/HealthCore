namespace Core.Data
{
    public class Allergy
    {
		private int id;
        private string description = "";
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

		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

	}
}
