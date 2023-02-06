using Resume.Data.Tables;

namespace Resume.Data.Queries.Interfaces;

public interface ISkillsQuery
{
    public Task<List<Skill>> GetSkillsByPersonId(int personId);
}