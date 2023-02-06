using Resume.Data.Commands.Interfaces;
using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Commands;

public class WorkExperienceCommands : IWorkExperienceCommands
{
    private readonly IWorkExperienceCommandsRepository _workExperienceCommandsRepository;

    public WorkExperienceCommands(IWorkExperienceCommandsRepository workExperienceCommandsRepository)
    {
        _workExperienceCommandsRepository = workExperienceCommandsRepository;
    }
    
    public async Task SaveNewWorkExperiences(IEnumerable<WorkExperience> workExperiences)
    {
        await _workExperienceCommandsRepository.SaveWorkExperiences(workExperiences);
    }
}