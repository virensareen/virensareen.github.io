using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data.Tables;

[Table("ProgrammingSkill")]
public sealed class ProgrammingSkill
{
    [Key]
    public int ProgrammingSkillId { get; set; }
    public string Name { get; set; }
    
    [ForeignKey("SkillId")]
    public Skill Skill { get; set; }
    public int SkillId { get; set; }
}