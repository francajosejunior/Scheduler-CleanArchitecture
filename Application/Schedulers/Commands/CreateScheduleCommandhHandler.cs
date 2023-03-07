using Application.Exceptions;
using Application.Interfaces.Repository;
using Domain.Entities;
using MediatR;

namespace Application.Schedulers.Commands
{
    public class CreateScheduleCommandhHandler : IRequestHandler<CreateScheduleCommand>
    {


        public async Task Handle(CreateScheduleCommand request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }
    }
}
