using Resume.Data.Commands.Interfaces;
using Resume.Data.Repositories.Interfaces;
using Resume.Data.Tables;

namespace Resume.Data.Commands;

public class ExtraCurricularCommands : IExtraCurricularCommands
{
    private readonly IExtraCurricularCommandsRepository _extraCurricularCommandsRepository;

    public ExtraCurricularCommands(IExtraCurricularCommandsRepository extraCurricularCommandsRepository)
    {
        _extraCurricularCommandsRepository = extraCurricularCommandsRepository;
    }
    
    public async Task SaveNewExtraCurriculars(IEnumerable<ExtraCurricular> extraCurriculars)
    {
        await _extraCurricularCommandsRepository.SaveExtraCurriculars(extraCurriculars);
    }
}