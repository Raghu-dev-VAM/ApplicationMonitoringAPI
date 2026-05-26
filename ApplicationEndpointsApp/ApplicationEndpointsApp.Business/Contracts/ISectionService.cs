using ApplicationEndpointsApp.Business.DTOs;

namespace ApplicationEndpointsApp.Business.Contracts;

public interface ISectionService
{
    Task<IEnumerable<SectionResponse>> GetAllAsync(CancellationToken cancellationToken);
    Task<SectionResponse?> GetByIdAsync(long id, CancellationToken cancellationToken);
    Task<IEnumerable<SectionResponse>> GetByApplicationIdAsync(long applicationId, CancellationToken cancellationToken);
    Task<long> AddAsync(SectionRequest request, CancellationToken cancellationToken);
    Task UpdateAsync(long id, SectionRequest request, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(long id, CancellationToken cancellationToken);
}
