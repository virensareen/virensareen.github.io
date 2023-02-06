using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Repositories;

public class PersonCommandsRepository : IPersonCommandsRepository
{
    public async Task SavePeople(IEnumerable<Person> people)
    {
        try
        {
            var dbContext = new DataContext();
        
            await dbContext.Person.AddRangeAsync(people);
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