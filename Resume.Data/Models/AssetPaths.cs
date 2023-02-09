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
        return Environment.GetEnvironmentVariable(name) ?? GetLocalPath(name);
    }
    
    private static string GetLocalPath(string name)
    {
        var config = ConfigurationHelper.GetConfiguration();
        var path = config.GetSection("AssetPaths:" + name).Value;
        
        return path ?? throw new InvalidOperationException();
    }
}