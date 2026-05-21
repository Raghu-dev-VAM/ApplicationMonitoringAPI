using Microsoft.EntityFrameworkCore;
using ApplicationEndpointsApp.Data.Contracts;
using ApplicationEndpointsApp.Data.Models;
using ApplicationEndpointsApp.Data.Context;

namespace ApplicationEndpointsApp.Data.Repositories;

public class ApplicationEndpointRepository : Repository<ApplicationEndpoints>, IApplicationEndpointRepository
{
    private readonly AppDbContext _context;

    public ApplicationEndpointRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ApplicationEndpoints>> GetByApplicationNameAsync(string applicationName, CancellationToken cancellationToken)
    {
        return await _context.ApplicationEndpoints
            .Where(e => e.ApplicationName != null && e.ApplicationName.Contains(applicationName))
            .ToListAsync(cancellationToken);
    }
}
