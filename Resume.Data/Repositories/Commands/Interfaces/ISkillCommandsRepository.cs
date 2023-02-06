using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface ISkillCommandsRepository
{
    public Task SaveSkill(List<Skill> skill);
}