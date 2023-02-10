using Resume.Data.Enums;
using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Repositories.Commands;

public class SkillCommandsRepository : ISkillCommandsRepository
{
    public async Task SaveSkill(List<Skill> skills)
    {
        try
        {
            var dbContext = new DataContext();

            foreach (var skill in skills.ToList())
            {
                switch (skill.SkillType)
                {
                    case SkillType.Soft:
                        await dbContext.SoftSkill.AddRangeAsync(skill.SoftSkills!);
                        await dbContext.Skill.AddRangeAsync(skills);
                        skills.RemoveAll(x => x.SkillType == SkillType.Soft);
                        break;
                    case SkillType.Tech:
                        await dbContext.TechSkill.AddRangeAsync(skill.TechSkills!);
                        await dbContext.Skill.AddRangeAsync(skills);
                        skills.RemoveAll(x => x.SkillType == SkillType.Tech);
                        break;
                    case SkillType.Programming:
                        await dbContext.ProgrammingSkill.AddRangeAsync(skill.ProgrammingSkills!);
                        await dbContext.Skill.AddRangeAsync(skills);
                        skills.RemoveAll(x => x.SkillType == SkillType.Programming);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }   
            }

            await dbContext.SaveChangesAsync();
            await dbContext.DisposeAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}