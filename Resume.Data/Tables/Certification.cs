using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data.Tables;

[Table("Certification")]
public sealed class Certification
{
    [Key]
    public int CertificationId { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime? DateOfCompletion { get; set; }
    public string? ImageUrl { get; set; }

    [ForeignKey("PersonId")]
    public Person Person { get; set; }
    public int PersonId { get; set; }
}