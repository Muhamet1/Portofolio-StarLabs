using MediatR;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Contacts
{
    public class Put
    {
        public class Command : IRequest
        {
            public Contact Contact { get; set; }
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
                var contact = await _context.Contacts.FindAsync(request.Contact.contactId);

                contact.contactName = request.Contact.contactName ?? contact.contactName;
                contact.contactEmail = request.Contact.contactEmail ?? contact.contactEmail;
                contact.contactMessage = request.Contact.contactMessage ?? contact.contactMessage;

                await _context.SaveChangesAsync();  
                return Unit.Value;
            }
        }
    }
}
