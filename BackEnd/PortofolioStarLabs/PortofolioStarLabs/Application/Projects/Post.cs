using MediatR;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Projects
{
    public class Post
    {
        public class Command : IRequest
        {
            public Project Project { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ApplicationDbContext _context;
            public Handler (ApplicationDbContext ctx)
            {
                _context = ctx;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Projects.Add(request.Project);

                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
