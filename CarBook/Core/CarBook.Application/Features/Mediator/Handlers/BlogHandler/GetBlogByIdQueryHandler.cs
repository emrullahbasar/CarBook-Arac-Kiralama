using CarBook.Application.Features.Mediator.Queries.BlogQuery;
using CarBook.Application.Features.Mediator.Results.BlogResult;
using CarBook.Application.Features.Mediator.Results.FeatureResult;
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
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
                AuthorID=values.AuthorID,
                CoverImageUrl=values.CoverImageUrl,
                Title = values.Title,
                BlogID = values.BlogID,
                CreatedDate=values.CreatedTime,
                CategoryID = values.CategoryID,
                Description=values.Description,
            };
        }
    }
}
