using Resume.Data.Commands.Interfaces;
using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Commands;

public class SkillCommands : ISkillCommands
{
    private readonly ISkillCommandsRepository _skillCommandsRepository;

    public SkillCommands(ISkillCommandsRepository skillCommandsRepository)
    {
        _skillCommandsRepository = skillCommandsRepository;
    }
    
    public async Task SaveNewSkills(List<Skill> skills)
    {
        await _skillCommandsRepository.SaveSkill(skills);
    }
}