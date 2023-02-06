using Resume.Data.Tables;

namespace Resume.Data.Queries.Interfaces;

public interface IPersonQuery
{
    public Task<Person> GetPersonByName(string name);
}