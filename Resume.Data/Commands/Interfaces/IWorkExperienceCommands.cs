using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface IWorkExperienceCommands
{
    public Task SaveNewWorkExperiences(IEnumerable<WorkExperience> workExperience);
}