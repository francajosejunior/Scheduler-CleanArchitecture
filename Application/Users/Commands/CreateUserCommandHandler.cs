using Application.Interfaces;
using Application.Interfaces.Repository;
using Domain.Entities;
using MediatR;

namespace Application.Users.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
       
        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
