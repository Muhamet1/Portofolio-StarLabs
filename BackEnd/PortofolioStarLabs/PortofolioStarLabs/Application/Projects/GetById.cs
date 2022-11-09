using MediatR;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Projects
{
    public class GetById
    {
        public class Query : IRequest<Project>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Project>
        {
            private readonly ApplicationDbContext _context;
            public Handler (ApplicationDbContext ctx)
            {
                _context = ctx;
            }
            public async Task<Project> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Projects.FindAsync(request.Id);
            }
        }

    }
}
