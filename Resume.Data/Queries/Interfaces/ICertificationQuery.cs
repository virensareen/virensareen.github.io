using Resume.Data.Tables;

namespace Resume.Data.Queries.Interfaces;

public interface ICertificationQuery
{
    public Task<List<Certification>> GetCertificationByPersonId(int personId);
}