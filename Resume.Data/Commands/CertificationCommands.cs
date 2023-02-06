using Resume.Data.Commands.Interfaces;
using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Commands;

public class CertificationCommands : ICertificationCommands
{
    private readonly ICertificationCommandsRepository _certificationCommandsRepository;

    public CertificationCommands(ICertificationCommandsRepository certificationCommandsRepository)
    {
        _certificationCommandsRepository = certificationCommandsRepository;
    }
    
    public async Task SaveNewCertifications(IEnumerable<Certification> certifications)
    {
        await _certificationCommandsRepository.SaveCertifications(certifications);
    }
}