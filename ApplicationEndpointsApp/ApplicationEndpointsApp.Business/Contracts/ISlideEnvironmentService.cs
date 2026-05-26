using ApplicationEndpointsApp.Business.DTOs;

namespace ApplicationEndpointsApp.Business.Contracts;

public interface ISlideEnvironmentService
{
    Task<IEnumerable<SlideEnvironmentResponse>> GetAllAsync(CancellationToken cancellationToken);
    Task<SlideEnvironmentResponse?> GetByIdAsync(long id, CancellationToken cancellationToken);
    Task<long> AddAsync(SlideEnvironmentRequest request, CancellationToken cancellationToken);
    Task UpdateAsync(long id, SlideEnvironmentRequest request, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(long id, CancellationToken cancellationToken);
}
