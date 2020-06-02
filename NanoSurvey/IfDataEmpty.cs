using NanoSurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey
{
    public class IfDataEmpty
    {
        public static void Initialize(MdlContext context)
        {
            if (!context.Surveys.Any())
            {
                context.Surveys.AddRange(
                    new Survey
                    {
                        NameSurvey = "Ты Робот?",
                        informationSurvey = "Этот опросник сможет узнать из плоти ты или из болтов и гаек"
                    },
                    new Survey
                    {
                        NameSurvey = "Зачем?",
                        informationSurvey = "Есть вещи которые мы все делаем ежедневно но каждый делает это по личной причине"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Questions.Any())
            {
                context.Questions.AddRange(
                    //1
                    new Question
                    {
                        Ask = "Твоя рука тяжелая?",
                        SurveyId = 1,
                        AskNum =1,
                    },
                    new Question
                    {
                        Ask = "У тебя ростут волосы?",
                        SurveyId = 1,
                        AskNum = 2
                    },
                    //2
                    new Question
                    {
                        Ask = "Зачем ломать зубную палочку",
                        SurveyId = 2,
                        AskNum = 1
                    },
                    new Question
                    {
                        Ask = "Зачем ты ешь козявки?",
                        SurveyId = 2,
                        AskNum =2
                    }
                );
                context.SaveChanges();
            }
            if (!context.Answers.Any())
            {
                context.Answers.AddRange(
                    //Твоя рука тяжелая ?
                    new Answer
                    {
                        Answers = "Нет?",
                        QuestionId = 1,
                        AnswerNum=1
                    },
                    new Answer
                    {
                        Answers = "Я не чувствую вес тела?",
                        QuestionId = 1,
                        AnswerNum=2
                    },
                    new Answer
                    {
                        Answers = "Жесть какая тяжелая?",
                        QuestionId = 1,
                        AnswerNum=3
                    },
                    //У тебя ростут волосы?
                    new Answer
                    {
                        Answers = "Были да выпали все",
                        QuestionId = 2,
                        AnswerNum=1
                    },
                    new Answer
                    {
                        Answers = "У меня волосы не меняются",
                        QuestionId = 2,
                        AnswerNum=2
                    },
                    new Answer
                    {
                        Answers = "Конечно",
                        QuestionId = 2,
                        AnswerNum=3
                    },
                    //Зачем ломать зубную палочку?
                    new Answer
                    {
                        Answers = "Таким не занимаюсь",
                        QuestionId = 3,
                        AnswerNum=1
                    },
                    new Answer
                    {
                        Answers = "От скуки",
                        QuestionId = 3,
                        AnswerNum=2
                    },
                    new Answer
                    {
                        Answers = "Я немного даун",
                        QuestionId = 3,
                        AnswerNum=3
                    },
                    //Зачем ты ешь козявки?
                    new Answer
                    {
                        Answers = "Фу",
                        QuestionId = 4,
                        AnswerNum=1
                    },
                    new Answer
                    {
                        Answers = "Это же бомба",
                        QuestionId = 4,
                        AnswerNum=2
                    },
                    new Answer
                    {
                        Answers = "Это мой бзик",
                        QuestionId = 4,
                        AnswerNum=3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
