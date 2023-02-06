using Microsoft.EntityFrameworkCore;
using Resume.Data.Queries.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Queries;

public class PersonQuery : IPersonQuery
{
    private readonly DataContext _dbContext = new DataContext();
    
    public async Task<Person> GetPersonByName(string name)
    {
        try
        {
            return await _dbContext.Person
                .Where(person => person.Name == name).FirstOrDefaultAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}