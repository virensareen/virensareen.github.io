using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface IWorkExperienceCommandsRepository
{
    public Task SaveWorkExperiences(IEnumerable<WorkExperience> workExperiences);
}