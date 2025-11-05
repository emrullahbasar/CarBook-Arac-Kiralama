using CarBook.Application.Features.Mediator.Queries.BlogQuery;
using CarBook.Application.Features.Mediator.Results.BlogResult;
using CarBook.Application.Features.Mediator.Results.TestimonialResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandler
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>

    {
        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBlogQueryResult
            {
                AuthorID = x.AuthorID,
                CoverImageUrl=x.CoverImageUrl,
                CategoryID = x.CategoryID,
                CreatedDate= x.CreatedTime,
                BlogID = x.BlogID,
                Title = x.Title,
                
            }).ToList();
        }
    }
}
