using Resume.Data.Tables;

namespace Resume.Data.Queries.Interfaces;

public interface IEducationQuery
{
    public Task<List<Education>> GetEducationsByPersonId(int personId);
}