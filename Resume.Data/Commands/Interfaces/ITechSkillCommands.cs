using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface ITechSkillCommands
{
    public Task SaveNewTechSkills(IEnumerable<TechSkill> techSkills);
}