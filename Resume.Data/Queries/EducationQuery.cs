using Microsoft.EntityFrameworkCore;
using Resume.Data.Queries.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Queries;

public class EducationQuery : IEducationQuery
{
    private readonly DataContext _dbContext = new DataContext();

    public async Task<List<Education>> GetEducationsByPersonId(int personId)
    {
        try
        {
            return await _dbContext.Education
                .Include(s => s.EducationAchievements)
                .Where(education => education.PersonId == personId).ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}