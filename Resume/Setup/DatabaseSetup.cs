using Microsoft.EntityFrameworkCore;
using Resume.Data;
using Resume.Data.DataSetup;

namespace Resume.Setup;

public static class DatabaseSetup
{
    private static readonly DataContext Db = new();
    
    public static async Task ResetDb()
    {
        var isResetNeeded = bool.Parse((Environment.GetEnvironmentVariable("ResetDb") 
                                        ?? ConfigurationHelper.GetConfiguration().GetSection("ResetDb").Value) 
                                        ?? throw new InvalidOperationException());
        if (!isResetNeeded)
        {
            return;
        }
        
        try
        {
            await ClearDb();
            await Db.Database.EnsureCreatedAsync();
            await SetupBase.PopulateSetupData();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private static async Task ClearDb()
    {
        var tableNames = new List<string>
        {
            "Certification", "Education", "ExtraCurricular", "Person",
            "ProgrammingSkill", "Skill", "SoftSkill", "TechSkill", "WorkExperience"
        };
        
        foreach (var tableName in tableNames)
        {
            await Db.Database.ExecuteSqlRawAsync($"DELETE FROM {tableName};");
        }
    }
}