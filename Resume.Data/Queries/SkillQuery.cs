using Microsoft.EntityFrameworkCore;
using Resume.Data.Queries.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Queries;

public class SkillsQuery : ISkillsQuery
{
    private readonly DataContext _dbContext = new DataContext();

    public async Task<List<Skill>> GetSkillsByPersonId(int personId)
    {
        try
        {
            var skill = await _dbContext.Skill
                .Include(s => s.TechSkills)
                .Include(s => s.SoftSkills)
                .Include(s => s.ProgrammingSkills)
                .Where(skill => skill.PersonId == personId).ToListAsync();

            return skill;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}