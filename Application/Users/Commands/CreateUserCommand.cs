using MediatR;

namespace Application.Users.Commands
{
    public class CreateUserCommand : IRequest
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Password { get; set; }
    }
}
