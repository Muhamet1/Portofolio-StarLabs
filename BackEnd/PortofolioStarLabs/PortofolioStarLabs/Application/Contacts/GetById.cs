using MediatR;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Contacts
{
    public class GetById
    {
        public class Query : IRequest<Contact>
        {
            public int Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Contact>
        {
            private readonly ApplicationDbContext _context;
            public Handler (ApplicationDbContext ctx)
            {
                _context = ctx;
            }
            public async Task<Contact> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Contacts.FindAsync(request.Id);
            }
        }
    }
}
