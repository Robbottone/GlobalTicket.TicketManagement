using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesDetailed;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesList;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CategoryController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet("all", Name = "GetAllCategories")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status401Unauthorized)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<ActionResult<List<CategoryViewModel>>> GetCategories(CancellationToken cancellationToken)
		{
			var result = await _mediator.Send(new GetCategoriesRequest(), cancellationToken);
			return Ok(result);
		}

		[HttpGet("allDetailed", Name = "GetAllCategoriesDetailed")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status401Unauthorized)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		public async Task<ActionResult<List<CategoryViewModel>>> GetCategoriesDetailed(CancellationToken cancellationToken)
		{
			var result = await _mediator.Send(new GetCategoriesDetailedRequest(), cancellationToken);
			return Ok(result);
		}

		[HttpGet("export", Name = "ExportEvents")]
		public async Task<FileResult> ExportEvents() {
			var fileDto = await _mediator.Send(new ExportCategoriesQuery());

			return File(fileDto.Data, fileDto.ContentType, fileDto.EventExportFileName);
		}
	}
}
