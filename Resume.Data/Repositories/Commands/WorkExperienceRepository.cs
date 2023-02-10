using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Repositories.Commands;

public class WorkExperienceCommandsRepository : IWorkExperienceCommandsRepository
{
    public async Task SaveWorkExperiences(IEnumerable<WorkExperience> workExperiences)
    {
        try
        {
            var dbContext = new DataContext();
        
            await dbContext.WorkExperience.AddRangeAsync(workExperiences);
            
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