using MediatR;

namespace Application.Users.Commands
{
    public class UpdateUserCommand : IRequest
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Password { get; set; }
    }
}
