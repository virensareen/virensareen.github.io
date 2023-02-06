using Microsoft.EntityFrameworkCore;
using Resume.Data.Queries.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Queries;

public class ExperienceQuery : IExperienceQuery
{
    private readonly DataContext _dbContext = new DataContext();

    public async Task<List<WorkExperience>> GetExperiencesByPersonId(int personId)
    {
        try
        {
            return await _dbContext.WorkExperience
                .Include(s => s.WorkAchievements)
                .Where(experience => experience.PersonId == personId).ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}