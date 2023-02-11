using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data.Tables;

[Table("ExtraCurricular")]
public sealed class ExtraCurricular
{
    [Key]
    public int ExtraCurricularId { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string? TimePeriod { get; set; }
    public string? ImageUrl { get; set; }

    [ForeignKey("PersonId")]
    public Person Person { get; set; }
    public int PersonId { get; set; }
}