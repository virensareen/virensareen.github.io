using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface ISkillCommands
{
    public Task SaveNewSkills(List<Skill> skill);
}