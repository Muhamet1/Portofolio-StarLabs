﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortofolioStarLabs.Application.Projects;
using PortofolioStarLabs.Models;
using static PortofolioStarLabs.Application.Projects.Post;

namespace PortofolioStarLabs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : BaseController
    {
        private readonly IMediator _mediator;
        public ProjectsController (IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetBrand()
        {
            return await _mediator.Send(new Get.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetById(int id)
        {
            return await _mediator.Send(new GetById.Query { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Project>> Post([FromForm] Command command)
        {
            return HandleResult(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Project>> Put(int id, Project project)
        {
            project.projectId = id;
            return Ok(await _mediator.Send(new Put.Command { Project = project }));

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new Delete.Command { Id = id }));
        }
    }
}
