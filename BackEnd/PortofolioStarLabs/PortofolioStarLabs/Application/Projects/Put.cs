using MediatR;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Projects
{
    public class Put
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
                var project = await _context.Projects.FindAsync(request.Project.projectId);

                project.projectTitle = request.Project.projectTitle ?? project.projectTitle;
                project.projectSubTitle = request.Project.projectSubTitle ?? project.projectSubTitle;
                project.projectDescription = request.Project.projectDescription ?? project.projectDescription;

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
