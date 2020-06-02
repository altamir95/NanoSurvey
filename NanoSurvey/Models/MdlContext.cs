using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class MdlContext : DbContext
    {
        public DbSet<Result> Results { get; set; }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public MdlContext(DbContextOptions<MdlContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
