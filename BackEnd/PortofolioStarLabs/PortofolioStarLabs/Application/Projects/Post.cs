using MediatR;
using PortofolioStarLabs.Application.Photos;
using PortofolioStarLabs.Models;
using PortofolioStarLabs.Persistence;

namespace PortofolioStarLabs.Application.Projects
{
    public class Post
    {
        public class Command : IRequest<Result<Project>>
        {
            public string projectTitle { get; set; }
            public string projectSubTitle { get; set; }
            public string projectDescription { get; set; }
            public string projectLink { get; set; }
            public IFormFile File { get; set; }
        }

        public class Handler : IRequestHandler<Command,Result<Project>>
        {
            private readonly ApplicationDbContext _context;
            private readonly IPhotoAccessor _photoAccessor;
            public Handler(ApplicationDbContext ctx,IPhotoAccessor photoAccessor)
            {
                _context = ctx;
                _photoAccessor = photoAccessor;

            }

            public async Task<Result<Project>> Handle(Command request, CancellationToken cancellationToken)
            {
                var photoResult = await _photoAccessor.AddPhoto(request.File);

                var project = new Project
                {
                    projectTitle = request.projectTitle,
                    projectSubTitle = request.projectSubTitle,
                    projectDescription = request.projectDescription,
                    projectLink = request.projectLink,
                    PhotoNum = photoResult.PublicId,
                    PhotoUrl = photoResult.Url
                };

                await _context.Projects.AddAsync(project);

                var success = await _context.SaveChangesAsync() > 0;

                if(success) return Result<Project>.Success(project);

                return Result<Project>.Failure("Problem Registering project");
            }
        }
    }
}
