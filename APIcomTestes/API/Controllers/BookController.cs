using Application.UseCases;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace API.Controllers
{
    [ApiController]
    [Route("api/controller")]
    [Consumes(MediaTypeNames.Application.Json)]
    public class BookController : ControllerBase
    {
        IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Create a new book.
        /// </summary>
        /// <param name="request">Book data</param>
        /// <response code="200">Book created successfully</response>
        /// <response code="400">There were mistakes in creating books. Check the parameters</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> CreateBook(CreateBookRequest request)
        {
            var book = await _mediator.Send(request);
            
            return Ok(book);
        }
    }
}
