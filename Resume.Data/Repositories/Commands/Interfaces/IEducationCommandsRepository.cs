using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface IEducationCommandsRepository
{
    public Task SaveEducations(IEnumerable<Education> educations);
}