﻿using MediatR;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Contacts
{
    public class Post
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
                _context.Contacts.Add(request.Contact);

                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
