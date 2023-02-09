namespace Resume.Data.DataSetup;

public static class DbConfig
{
    
    public static string GetConnString(string name)
    {
        var connectionString = Environment.GetEnvironmentVariable(name);

        if (connectionString != null)
        {
            return connectionString;
        }
        
        var config = ConfigurationHelper.GetConfiguration();
        return config.GetSection(name).Value ?? throw new InvalidOperationException();
    }
}