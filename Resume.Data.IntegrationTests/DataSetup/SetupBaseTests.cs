using Resume.Data.DataSetup;
using Shouldly;

namespace Resume.Data.IntegrationTests.DataSetup;

[TestFixture]
public class SetupBaseTests
{
    private DataContext _dbContext;

    [SetUp]
    public async Task SetUp()
    {
        _dbContext = new DataContext();
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.Database.EnsureCreatedAsync();
    }

    [TestCase]
    public async Task Must_Populate_Setup_Data_To_Database()
    {
        await SetupBase.PopulateSetupData();

        var person = _dbContext.Person.FirstOrDefault(x => x.Name == "Viren Sareen");

        person.ShouldNotBeNull();
        person.Name.ShouldBe("Viren Sareen");
    }
}