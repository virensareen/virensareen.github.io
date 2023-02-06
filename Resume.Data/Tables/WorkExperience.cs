using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data.Tables;

[Table("WorkExperience")]
public sealed class WorkExperience
{
    [Key]
    public int WorkExperienceId { get; set; }
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public string Location { get; set; }
    public string? TimePeriod { get; set; }
    public string? LogoUrl { get; set; }
    public List<WorkAchievement>? WorkAchievements { get; set; }
    
    [ForeignKey("PersonId")]
    public Person Person { get; set; }
    public int PersonId { get; set; }
}

[Table("WorkAchievement")]
public sealed class WorkAchievement
{
    [Key]
    public int WorkAchievementId { get; set; }
    public string Description { get; set; }

    [ForeignKey("WorkExperienceId")]
    public WorkExperience WorkExperience { get; set; }
    public int WorkExperienceId { get; set; }
}