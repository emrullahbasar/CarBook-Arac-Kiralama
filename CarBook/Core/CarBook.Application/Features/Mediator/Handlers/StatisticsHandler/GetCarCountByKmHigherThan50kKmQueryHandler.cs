using CarBook.Application.Features.Mediator.Queries.StatisticsQuery;
using CarBook.Application.Features.Mediator.Results.StatisticsResult;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandler
{
    public class GetCarCountByKmHigherThan50kKmQueryHandler : IRequestHandler<GetCarCountByKmHigherThan50kKmQuery, GetCarCountByKmHigherThan50kKmQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKmHigherThan50kKmQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmHigherThan50kKmQueryResult> Handle(GetCarCountByKmHigherThan50kKmQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmHigherThan50kKm();
            return new GetCarCountByKmHigherThan50kKmQueryResult
            {
                CarCountByKmHigherThan50kKm = value,
            };
        }
    }
}
