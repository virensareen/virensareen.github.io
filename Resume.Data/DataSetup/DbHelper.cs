namespace Resume.Data.DataSetup;

public static class DbHelper
{
    public static int GetPersonIdByName(string name)
    {
        var personDbContext = new DataContext();
        return personDbContext.Person.FirstOrDefault(row => row!.Name == name)!.PersonId;
    }
}