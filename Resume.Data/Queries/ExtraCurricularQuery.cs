using Microsoft.EntityFrameworkCore;
using Resume.Data.Tables;

namespace Resume.Data.Queries;

public class ExtraCurricularQuery
{
    private readonly DataContext _dbContext = new DataContext();
    
    public async Task<List<ExtraCurricular>> GetExtraCurricularsByPersonId(int personId)
    {
        try
        {
            return await _dbContext.ExtraCurricular.Where(ec => ec.PersonId == personId).ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}