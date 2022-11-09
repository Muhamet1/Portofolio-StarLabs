using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortofolioStarLabs.Application.Contacts;
using PortofolioStarLabs.Models;

namespace PortofolioStarLabs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : BaseController
    {
        private readonly IMediator _mediator;
        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }
     [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetContacts()
        {
            return await _mediator.Send(new Get.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetById(int id)
        {
            return await _mediator.Send(new GetById.Query { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Contact>> Post(Contact contact)
        {
            return Ok(await Mediator.Send(new Post.Command { Contact = contact }));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Contact>> Put(int id, Contact contact)
        {
            contact.contactId = id;
            return Ok(await _mediator.Send(new Put.Command { Contact = contact }));

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new Delete.Command { Id = id }));
        }

    }
}
