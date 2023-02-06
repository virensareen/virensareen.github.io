using Resume.Data.Tables;

namespace Resume.Data.Repositories.Interfaces;

public interface ICertificationCommandsRepository
{
    public Task SaveCertifications(IEnumerable<Certification> certifications);
}