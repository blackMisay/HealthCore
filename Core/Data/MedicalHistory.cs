using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class MedicalHistory
    {
        private int id;
        List<MedicalQuestion>? PatientMedicalQuestion;
        List<Allergy>? PatientAllergies;
        List<Disease>? PatientIllness;
        List<Surgery>? PatientSurgeries;
        List<Vaccine>? PatientImmunications;
        List<MedicalExamination>? PatientMedicalExaminations;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
