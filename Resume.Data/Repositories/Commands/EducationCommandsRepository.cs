using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Repositories;

public class EducationCommandsRepository : IEducationCommandsRepository
{
    public async Task SaveEducations(IEnumerable<Education> educations)
    {
        try
        {
            var dbContext = new DataContext();

            await dbContext.Education.AddRangeAsync(educations);
            
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