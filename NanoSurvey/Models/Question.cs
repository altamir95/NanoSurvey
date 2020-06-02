using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
    //ВОПРОСЫ АНКЕТЫ
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Ask { get; set; }
        public int AskNum { get; set; }
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
    }
}
