using Case1ResumeProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace Case1ResumeProject.Context
{
    public class ResumeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-N905OEG\\SQLEXPRESS;initial catalog=Case1DbResumeProject;integrated security=true;trust server certificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<ProfileTitle> ProfileTitles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
    