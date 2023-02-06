using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface IProgrammingSkillCommandsRepository
{
    public Task SaveProgrammingSkill(IEnumerable<ProgrammingSkill> programmingSkill);
}