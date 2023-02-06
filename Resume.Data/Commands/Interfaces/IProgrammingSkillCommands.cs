using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface IProgrammingSkillCommands
{
    public Task SaveNewProgrammingSkills(IEnumerable<ProgrammingSkill> programmingSkill);
}