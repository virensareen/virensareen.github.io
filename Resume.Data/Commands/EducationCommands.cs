using Resume.Data.Commands.Interfaces;
using Resume.Data.Repositories;
using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Commands;

public class EducationCommands : IEducationCommands
{
    private readonly IEducationCommandsRepository _educationCommandsRepository;

    public EducationCommands(IEducationCommandsRepository educationCommandsRepository)
    {
        _educationCommandsRepository = educationCommandsRepository;
    }
    
    public async Task SaveNewEducations(IEnumerable<Education> educations)
    {
       await _educationCommandsRepository.SaveEducations(educations);
    }
}