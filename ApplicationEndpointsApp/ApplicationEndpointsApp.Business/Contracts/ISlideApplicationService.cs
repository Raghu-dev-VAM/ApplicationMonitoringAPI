using ApplicationEndpointsApp.Business.DTOs;

namespace ApplicationEndpointsApp.Business.Contracts;

public interface ISlideApplicationService
{
    Task<IEnumerable<SlideApplicationResponse>> GetAllAsync(CancellationToken cancellationToken);
    Task<SlideApplicationResponse?> GetByIdAsync(long id, CancellationToken cancellationToken);
    Task<long> AddAsync(SlideApplicationRequest request, CancellationToken cancellationToken);
    Task UpdateAsync(long id, SlideApplicationRequest request, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(long id, CancellationToken cancellationToken);
}
