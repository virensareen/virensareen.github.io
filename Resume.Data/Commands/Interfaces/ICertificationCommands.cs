using Resume.Data.Tables;

namespace Resume.Data.Commands.Interfaces;

public interface ICertificationCommands
{
    public Task SaveNewCertifications(IEnumerable<Certification> certification);
}