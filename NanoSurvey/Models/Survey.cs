using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
    //ИНФОРМАЦИЯ ОБ АНКЕТЕ
{
    public class Survey
    {
        public int Id { get; set; }
        public string NameSurvey { get; set; }
        public string informationSurvey { get; set; }
    }
}
