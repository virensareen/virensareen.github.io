using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data.Tables;

[Table("TechSkill")]
public sealed class TechSkill
{
    [Key]
    public int TechSkillId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    
    [ForeignKey("SkillId")]
    public Skill Skill { get; set; }
    public int SkillId { get; set; }
}