using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface IExtraCurricularCommands
{
    public Task SaveNewExtraCurriculars(IEnumerable<ExtraCurricular> extraCurriculars);
}