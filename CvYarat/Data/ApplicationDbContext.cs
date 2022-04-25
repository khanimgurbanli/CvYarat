using CvYarat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CvYarat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<ClientSkill>().HasKey(am => new
        //    {
        //        am.ClientId,
        //        am.SkillId
        //    });
        //    builder.Entity<ClientSkill>().HasOne(m => m.Skill).WithMany(am => am.SkillsClient).HasForeignKey(m => m.SkillId);
        //    builder.Entity<ClientSkill>().HasOne(m => m.Client).WithMany(am => am.ClientSkills).HasForeignKey(m => m.ClientId);

        //    builder.Entity<ClientTraining>().HasKey(am => new
        //    {
        //        am.ClientId,
        //        am.TrainingId
        //    });
        //    builder.Entity<ClientTraining>().HasOne(m => m.Training).WithMany(am => am.TrainingsClient).HasForeignKey(m => m.TrainingId);
        //    builder.Entity<ClientTraining>().HasOne(m => m.Client).WithMany(am => am.ClientTrainings).HasForeignKey(m => m.ClientId);
        //}



        public DbSet<City> Cities { get; set; }
        public DbSet<Deportament> Deportaments { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<EduInstitution> EduInstitutions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientTraining> ClientTrainings { get; set; }
        public DbSet<ClientSkill> ClientSkills { get; set; }
        public DbSet<StatusRole> StatusRoles { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
    }
}
