using Microsoft.EntityFrameworkCore;
using Resume.Data.Queries.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Queries;

public class CertificationQuery : ICertificationQuery
{
    private readonly DataContext _dbContext = new DataContext();

    public async Task<List<Certification>> GetCertificationByPersonId(int personId)
    {
        try
        {
            return await _dbContext.Certification.Where(certification => certification.PersonId == personId).ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}