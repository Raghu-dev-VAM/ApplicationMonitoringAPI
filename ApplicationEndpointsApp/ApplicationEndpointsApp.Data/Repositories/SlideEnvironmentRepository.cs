using ApplicationEndpointsApp.Data.Contracts;
using ApplicationEndpointsApp.Data.Models;
using ApplicationEndpointsApp.Data.Context;

namespace ApplicationEndpointsApp.Data.Repositories;

public class SlideEnvironmentRepository : Repository<SlideEnvironment>, ISlideEnvironmentRepository
{
    public SlideEnvironmentRepository(AppDbContext context) : base(context) { }
}
