using Newtonsoft.Json;
using Resume.Data.Commands;
using Resume.Data.Enums;
using Resume.Data.Models;
using Resume.Data.Repositories.Commands;
using Resume.Data.Tables;

namespace Resume.Data.DataSetup;

public static class SetupBase
{
    public static async Task PopulateSetupData()
    {
        var personCommand = new PersonCommands(new PersonCommandsRepository());
        var people = FetchDataFromJson(new List<Person>(), 
            Path.Combine(GetProjectRoot(), AssetPaths.Person));
        await personCommand.SaveNewPeople(people);

        var personId = DbHelper.GetPersonIdByName("Viren Sareen");
        
        var educationCommand = new EducationCommands(new EducationCommandsRepository());
        var educations = FetchDataFromJson(new List<Education>(), 
            Path.Combine(GetProjectRoot(), AssetPaths.Education));
        educations.ForEach(education => education.PersonId = personId);
        await educationCommand.SaveNewEducations(educations);

        var workExperienceCommand = new WorkExperienceCommands(new WorkExperienceCommandsRepository());
        var workExperiences = FetchDataFromJson(new List<WorkExperience>(), 
            Path.Combine(GetProjectRoot(), AssetPaths.WorkExperience));
        workExperiences.ForEach(workExperience => workExperience.PersonId = personId);
        await workExperienceCommand.SaveNewWorkExperiences(workExperiences);

        var certificationCommand = new CertificationCommands(new CertificationCommandsRepository());
        var certifications = FetchDataFromJson(new List<Certification>(), 
            Path.Combine(GetProjectRoot(), AssetPaths.Certification));
        certifications.ForEach(certification => certification.PersonId = personId);
        await certificationCommand.SaveNewCertifications(certifications);
        
        var extraCurricularCommand = new ExtraCurricularCommands(new ExtraCurricularCommandsRepository());
        var extraCurriculars = FetchDataFromJson(new List<ExtraCurricular>(), 
            Path.Combine(GetProjectRoot(), AssetPaths.ExtraCurricular));
        extraCurriculars.ForEach(extraCurricular => extraCurricular.PersonId = personId);
        await extraCurricularCommand.SaveNewExtraCurriculars(extraCurriculars);
        
        var skillCommand = new SkillCommands(new SkillCommandsRepository());
        var programmingSkills = FetchDataFromJson(new List<ProgrammingSkill>(), 
            Path.Combine(GetProjectRoot(), AssetPaths.ProgrammingSkill));
        var techSkills = FetchDataFromJson(new List<TechSkill>(), 
            Path.Combine(GetProjectRoot(), AssetPaths.TechSkill));
        var softSkills = FetchDataFromJson(new List<SoftSkill>(), 
            Path.Combine(GetProjectRoot(), AssetPaths.SoftSkill));

        var skills = new List<Skill>();
        programmingSkills.MapToSkillEntity(skills, SkillType.Programming);
        techSkills.MapToSkillEntity(skills, SkillType.Tech);
        softSkills.MapToSkillEntity(skills, SkillType.Soft);
        skills.ForEach(skill => skill.PersonId = personId);
        
        await skillCommand.SaveNewSkills(skills);
    }

    private static void MapToSkillEntity<T>(this List<T> specificSkills, ICollection<Skill> skills, SkillType skillType)
    {
        foreach (var specificSkill in specificSkills)
        {
            var skill = new Skill
            {
                SkillType = skillType
            };
            
            switch (skillType)
            {
                case SkillType.Soft:
                    skill.SoftSkills = new List<SoftSkill>
                    {
                        (SoftSkill)(specificSkill! as object)
                    };
                    break;
                case SkillType.Tech:
                    skill.TechSkills = new List<TechSkill>
                    {
                        (TechSkill)(specificSkill! as object)
                    };
                    break;
                case SkillType.Programming:
                    skill.ProgrammingSkills = new List<ProgrammingSkill>
                    {
                        (ProgrammingSkill)(specificSkill! as object)
                    };
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(skillType), skillType, null);
            }
            
            skills.Add(skill);
        }
    }

    private static T FetchDataFromJson<T>(T obj, string filePath)
    {
        obj = JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath)) 
                     ?? throw new InvalidOperationException();

        return obj;
    }

    private static string GetProjectRoot()
    {
        return Directory.GetParent(Directory.GetCurrentDirectory())!.FullName;
    }
}