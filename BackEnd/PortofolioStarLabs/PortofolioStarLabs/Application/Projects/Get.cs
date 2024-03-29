﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Projects
{
    public class Get
    {
        public class Query : IRequest<List<Project>> { }

        public class Handler : IRequestHandler<Query, List<Project>>
        {
            private readonly ApplicationDbContext _context;
            public Handler (ApplicationDbContext ctx)
            {
                _context = ctx;
            }
            public async Task<List<Project>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Projects.ToListAsync();
            }
        }
    }
}
