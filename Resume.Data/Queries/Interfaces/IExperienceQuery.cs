using Resume.Data.Tables;

namespace Resume.Data.Queries.Interfaces;

public interface IExperienceQuery
{
    public Task<List<WorkExperience>> GetExperiencesByPersonId(int personId);
}