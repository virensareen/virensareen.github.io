using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface ITechSkillCommandsRepository
{
    public Task SaveTechSkills(IEnumerable<TechSkill> techSkills);
}