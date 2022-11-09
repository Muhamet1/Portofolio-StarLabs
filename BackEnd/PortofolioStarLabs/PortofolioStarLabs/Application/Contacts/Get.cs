using MediatR;
using Microsoft.EntityFrameworkCore;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Contacts
{
    public class Get
    {
        public class Query : IRequest<List<Contact>> { }

        public class Handler : IRequestHandler<Query, List<Contact>>
        {
            private readonly ApplicationDbContext _context;
            public Handler (ApplicationDbContext ctx)
            {
                _context = ctx;
            }
            public async Task<List<Contact>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Contacts.ToListAsync();
            }
        }
    }
}
