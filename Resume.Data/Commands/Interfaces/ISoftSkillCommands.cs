using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface ISoftSkillCommands
{
    public Task SaveNewSoftSkills(IEnumerable<SoftSkill> softSkills);
}