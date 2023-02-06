using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Repositories;

public class ExtraCurricularCommandsRepository : IExtraCurricularCommandsRepository
{
    public async Task SaveExtraCurriculars(IEnumerable<ExtraCurricular> extraCurriculars)
    {
        try
        {
            var dbContext = new DataContext();
        
            await dbContext.ExtraCurricular.AddRangeAsync(extraCurriculars);
            
            await dbContext.SaveChangesAsync();
            await dbContext.DisposeAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}