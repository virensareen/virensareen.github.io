using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface IEducationCommands
{
    public Task SaveNewEducations(IEnumerable<Education> educations);
}