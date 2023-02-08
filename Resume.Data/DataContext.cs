using Microsoft.EntityFrameworkCore;
using Resume.Data.DataSetup;
using Resume.Data.Tables;

namespace Resume.Data;

public class DataContext : DbContext
{
    public DbSet<Person> Person { get; set; }
    public DbSet<Education> Education { get; set; }
    public DbSet<WorkExperience> WorkExperience { get; set; }
    public DbSet<ExtraCurricular> ExtraCurricular { get; set; }
    public DbSet<Certification> Certification { get; set; }
    public DbSet<Skill> Skill { get; set; }
    public DbSet<TechSkill> TechSkill { get; set; }
    public DbSet<SoftSkill> SoftSkill { get; set; }
    public DbSet<ProgrammingSkill> ProgrammingSkill { get; set; }
    public DbSet<EducationAchievement> EducationAchievement { get; set; }
    public DbSet<WorkAchievement> WorkAchievement { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var conn = DbConfig.GetConnString("ConnectionStrings:db");
        options.UseSqlServer(conn);
    }
}