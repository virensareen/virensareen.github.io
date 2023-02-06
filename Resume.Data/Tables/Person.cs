using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data.Tables;

[Table("Person")]
public sealed class Person
{
    [Key]
    public int PersonId { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Location { get; set; }
    public string? Social { get; set; }
    public string? Intro { get; set; }
    public string? ImageUrl { get; set; }
    
    public List<Education>? Educations { get; set; }
    public List<WorkExperience>? WorkExperiences { get; set; }
    public List<ExtraCurricular>? ExtraCurriculars { get; set; }
    public List<Certification>? Certifications { get; set; }
    public List<Skill>? Skills { get; set; }
}