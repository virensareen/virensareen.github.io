using Resume.Data;
using Resume.Data.DataSetup;

namespace Resume.Setup;

public static class DatabaseSetup
{
    private static readonly DataContext Db = new();
    public static async Task EnsureDbExists()
    {
        try
        {
            if (await Db.Database.CanConnectAsync() == false)
            {
                await Db.Database.EnsureCreatedAsync();
                await SetupBase.PopulateSetupData();
            }

            await Db.DisposeAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static async Task ResetDb()
    {
        await Db.Database.EnsureDeletedAsync();
        await Db.Database.EnsureCreatedAsync();
        await SetupBase.PopulateSetupData();
        
        await Db.DisposeAsync();
    }
}