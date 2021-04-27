using System;
using System.Collections.Generic;
using System.Text;
using ExamPortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExamPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {

                    Name = "Examiner",
                    NormalizedName = "EXAMINER"
                },
                new IdentityRole
                {

                    Name = "Candidate",
                    NormalizedName = "CANDIDATE"
                },
                new IdentityRole
                {

                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });;

            //builder.Entity<CandidateInTest>().HasNoKey().ToTable("CandidateInTests");
            //builder.Entity<CandidateInTest>()
        }

        public DbSet<QuestionAndAnswer> QuestionAndAnswers { get; set; }

        public DbSet<Test> Tests { get; set; }

        public DbSet<CandidateInTest> CandidateInTests { get; set; }

        public DbSet<FlaggedQuestion> FlaggedQuestions { get; set; }

        public DbSet<CandidateChoice> CandidateChoices { get; set; }

        public DbSet<CandidateTestResult> CandidateTestResults { get; set; }
    }
}
