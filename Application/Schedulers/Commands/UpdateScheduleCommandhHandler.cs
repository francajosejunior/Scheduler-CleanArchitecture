using Application.Exceptions;
using Application.Interfaces.Repository;
using Domain.Entities;
using MediatR;

namespace Application.Schedulers.Commands
{
    public class UpdateScheduleCommandhHandler : IRequestHandler<UpdateScheduleCommand>
    {



        public async Task Handle(UpdateScheduleCommand request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();

        }
    }
}
