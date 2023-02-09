using Microsoft.Extensions.Configuration;
using Resume.Data.DataSetup;

namespace Resume.Data.Models;

public static class AssetPaths
{
    private static ConfigurationBuilder _configurationBuilder;

    public static string Certification => GetPath("Certification");
    public static string Education => GetPath("Education");
    public static string ExtraCurricular => GetPath("ExtraCurricular");
    public static string Person => GetPath("Person");
    public static string ProgrammingSkill => GetPath("ProgrammingSkill");
    public static string SoftSkill => GetPath("SoftSkill");
    public static string TechSkill => GetPath("TechSkill");
    public static string WorkExperience => GetPath("WorkExperience");

    private static string GetPath(string name)
    {
        var fullName = "AssetPaths:" + name;
        return Environment.GetEnvironmentVariable(fullName) ?? GetLocalPath(fullName);
    }
    
    private static string GetLocalPath(string fullName)
    {
        var config = ConfigurationHelper.GetConfiguration();
        var path = config.GetSection(fullName).Value;
        
        return path ?? throw new InvalidOperationException();
    }
}