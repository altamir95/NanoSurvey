using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NanoSurvey.Models;

namespace NanoSurvey.Controllers
{
    public class Post
    {
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public string Ask { get; set; }
        public string Answers { get; set; }
    }
    class Steps
    {
        //public Answer User { get; set; }
        public Answer Step1 { get; set; }
        public Answer Step2 { get; set; }
        public Answer Step3 { get; set; }

    }
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SurveyController : ControllerBase
    {
        MdlContext db;
        public SurveyController(MdlContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Survey>>> Get()
        {
            return await db.Surveys.ToListAsync();
        }
        [HttpGet("{id}/{id2?}")]
        public async Task<ActionResult<Answer>> Get(int id, int id2)
        {
            Survey step1 = await db.Surveys.FirstOrDefaultAsync(x => x.Id == id);
            Question step2 = await db.Questions.FirstOrDefaultAsync(x => x.SurveyId == id && x.AskNum == id2);

            Answer step3 = await db.Answers.FirstOrDefaultAsync(x => x.QuestionId == step2.QuestionId && x.AnswerNum == 1);
            Answer step4 = await db.Answers.FirstOrDefaultAsync(x => x.QuestionId == step2.QuestionId && x.AnswerNum == 2);
            Answer step5 = await db.Answers.FirstOrDefaultAsync(x => x.QuestionId == step2.QuestionId && x.AnswerNum == 3);

            if (step1 == null)
                return Redirect($"api/User");
            if (step2 == null)
                return Redirect($"api/User");
            Steps stp= new Steps();
            stp.Step1 = step3;
            stp.Step2 = step4;
            stp.Step3 = step5;
            return new ObjectResult(stp);


        }
       [HttpPost("{id}/{id2}")]
        public async Task<ActionResult<Post>> Post(Post post)
        {
            db.Results.Add(new Result { InterviewName = User.Identity.Name, UsAsk = post.Ask,HeAnswer= post.Answers });
            await db.SaveChangesAsync();
            return Redirect($"api/User/{post.SurveyId}/{post.QuestionId+1}");
        }
    }
}
