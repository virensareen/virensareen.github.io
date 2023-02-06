using Resume.Data.Commands.Interfaces;
using Resume.Data.Repositories;
using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Commands;

public class PersonCommands : IPersonCommands
{
    private readonly IPersonCommandsRepository _personCommandsRepository;
    
    public PersonCommands(IPersonCommandsRepository personCommandsRepository)
    {
        _personCommandsRepository = personCommandsRepository;
    }
    
    public async Task SaveNewPeople(List<Person> people)
    {
        await _personCommandsRepository.SavePeople(people);
    }
}