using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface IPersonCommands
{
    public Task SaveNewPeople(List<Person> person);
}