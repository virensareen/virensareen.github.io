using Microsoft.Extensions.Configuration;

namespace Resume.Data.DataSetup;

public static class ConfigurationHelper
{
    private static IConfiguration _configuration;

    public static IConfiguration GetConfiguration()
    {
        if (_configuration != null)
        {
            return _configuration;
        }

        _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        return _configuration;
    }
}