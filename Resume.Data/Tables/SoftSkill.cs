using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data.Tables;

[Table("SoftSkill")]
public sealed class SoftSkill
{
    [Key]
    public int SoftSkillId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    
    [ForeignKey("SkillId")]
    public Skill Skill { get; set; }
    public int SkillId { get; set; }
}