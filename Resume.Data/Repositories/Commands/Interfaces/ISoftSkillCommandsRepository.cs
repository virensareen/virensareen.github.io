using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface ISoftSkillCommandsRepository
{
    public Task SaveSoftSkills(IEnumerable<SoftSkill> softSkills);
}