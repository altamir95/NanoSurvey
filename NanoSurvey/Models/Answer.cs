using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
    //ВАРИАНТЫ ОТВЕТА НА ВОПРОС АНКЕТЫ
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Answers { get; set; }
        public int AnswerNum { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
