using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface IExtraCurricularCommandsRepository
{
    public Task SaveExtraCurriculars(IEnumerable<ExtraCurricular> extraCurriculars);
}