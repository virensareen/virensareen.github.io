using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Repositories;

public class CertificationCommandsRepository : ICertificationCommandsRepository
{
    public async Task SaveCertifications(IEnumerable<Certification> certifications)
    {
        try
        {
            var dbContext = new DataContext();
        
            await dbContext.Certification.AddRangeAsync(certifications);
            
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