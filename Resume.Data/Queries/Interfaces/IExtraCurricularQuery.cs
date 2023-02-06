using Resume.Data.Tables;

namespace Resume.Data.Queries.Interfaces;

public interface IExtraCurricularQuery
{
    public Task<List<ExtraCurricular>> GetExtraCurricularsByPersonId(int personId);
}