using CarBook.Application.Features.Mediator.Commands.RezervationCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.RezervationHandlers
{
    public class CreateRezervationCommandHandler : IRequestHandler<CreateRezervationCommand>
    {
        private readonly IRepository<Rezervation> _repository;

        public CreateRezervationCommandHandler(IRepository<Rezervation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateRezervationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Rezervation
            {
                Age = request.Age,
                CarID = request.CarID,
                Description = request.Description,
                DriverLicanceYear = request.DriverLicanceYear,
                DropOffLocationID = request.DropOffLocationID,
                Email = request.Email,
                Name = request.Name,
                Phone = request.Phone,
                SurName = request.SurName,
                PickUpLocationID = request.PickUpLocationID,
                Status = "Rezervasyon Alındı",
            });
        }
    }
}
