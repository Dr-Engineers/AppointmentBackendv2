using Appointment.common.Entities.Preset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.common.Entities
{
    public class Recommendation
    {
        public int RecommendationID { get; set; }
        public List<Clinic> RecommendedClinicID { get; set; }
        public List<Doctor> RecommendedDoctorID { get; set; }
    }
}
