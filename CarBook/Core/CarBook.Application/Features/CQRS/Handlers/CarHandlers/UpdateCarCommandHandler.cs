using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            values.BigImageUrl = command.BigImageUrl;
            values.Km=command.Km;
            values.Seat=command.Seat;
            values.Transmission=command.Transmission;
            values.CarID = command.CarID;
            values.Fuel=command.Fuel;
            values.Model=command.Model;
            values.Luggage=command.Luggage;
            values.CoverImageUrl=command.CoverImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
