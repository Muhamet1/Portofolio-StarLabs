using MediatR;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Contacts
{
    public class Delete
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
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
                var context = await _context.Contacts.FindAsync(request.Id);
                _context.Remove(context);
                
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
