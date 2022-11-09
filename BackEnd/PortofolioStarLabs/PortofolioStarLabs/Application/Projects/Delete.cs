using MediatR;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Projects
{
    public class Delete
    {
        public class Command : IRequest
        {
            public int Id {get;set;}
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
                var project = await _context.Projects.FindAsync(request.Id);
                _context.Remove(project);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
