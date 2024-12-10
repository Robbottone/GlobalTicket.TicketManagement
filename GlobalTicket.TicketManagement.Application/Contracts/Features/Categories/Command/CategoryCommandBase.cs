using AutoMapper;
using FluentValidation;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command;

public abstract class CategoryCommandBase<TRequest, TResult>: CategoryBase, IRequestHandler<TRequest, TResult> where TRequest : class, IRequest<TResult>
{
	public CategoryCommandBase(ICategoryRepository categoryRepository, IMapper mapper): base(categoryRepository, mapper)
	{
	}

	public abstract Task<TResult> Handle(TRequest request, CancellationToken cancellationToken);
}

public abstract class CategoryCommandBase<TRequest>: CategoryBase, IRequestHandler<TRequest> where TRequest : class, IRequest
{
	public CategoryCommandBase(ICategoryRepository categoryRepository, IMapper mapper): base(categoryRepository, mapper)
	{
	}

	public abstract Task Handle(TRequest request, CancellationToken cancellationToken);
}

public class CategoryBase
{
	public readonly ICategoryRepository categoryRepository;
	public readonly IMapper mapper;
	public CategoryBase(ICategoryRepository categoryRepository, IMapper mapper)
	{
		this.categoryRepository = categoryRepository;
		this.mapper = mapper;
	}
}
