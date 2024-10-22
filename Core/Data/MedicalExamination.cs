namespace Core.Data
{
    public class MedicalExamination
    {
		private int id;
        private MedicalExam type;
        private string description = "";
        private string remarks = "";

        public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public MedicalExam Type
		{
			get { return type; }
			set { type = value; }
		}


		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public string Remarks
		{
			get { return remarks ; }
			set { remarks  = value; }
		}
	}
}
