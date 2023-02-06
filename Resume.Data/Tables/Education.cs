using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data.Tables;

[Table("Education")]
public sealed class Education
{
    [Key]
    public int EducationId { get; set; }
    public string School { get; set; }
    public string Course { get; set; }
    public string? Grade { get; set; }
    public DateTime? GraduationDate { get; set; }
    public string? LogoUrl { get; set; }
    public List<EducationAchievement>? EducationAchievements { get; set; }
    
    [ForeignKey("PersonId")]
    public Person Person { get; set; }
    public int PersonId { get; set; }
}

[Table("EducationAchievement")]
public sealed class EducationAchievement
{
    [Key]
    public int EducationAchievementId { get; set; }
    public string? Description { get; set; }

    [ForeignKey("EducationId")]
    public Education Education { get; set; }
    public int EducationId { get; set; }
}