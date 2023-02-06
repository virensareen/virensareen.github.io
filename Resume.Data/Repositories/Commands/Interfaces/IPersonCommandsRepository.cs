using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface IPersonCommandsRepository
{
    public Task SavePeople(IEnumerable<Person> people);
}