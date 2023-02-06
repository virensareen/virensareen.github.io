using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Resume.Data.Enums;

namespace Resume.Data.Tables;

[Table("Skill")]
public sealed class Skill
{
    [Key]
    public int SkillId { get; set; }
    public SkillType SkillType { get; set; }
    public List<TechSkill>? TechSkills { get; set; }
    public List<SoftSkill>? SoftSkills { get; set; }
    public List<ProgrammingSkill>? ProgrammingSkills { get; set; }
    
    [ForeignKey("PersonId")]
    public Person Person { get; set; }
    public int PersonId { get; set; }
}