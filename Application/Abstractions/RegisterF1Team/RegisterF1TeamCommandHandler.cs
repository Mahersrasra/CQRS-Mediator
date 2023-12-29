
using domain.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Abstractions.RegisterF1Team
{
    internal sealed class RegisterF1TeamCommandHandler : IRequestHandler<RegisterF1TeamCommand, Guid>
    {
        private readonly IF1TeamRepository _f1TeamRepository;
        public RegisterF1TeamCommandHandler(IF1TeamRepository f1TeamRepository)
        {
            _f1TeamRepository = f1TeamRepository;
        }
        public Task<Guid> Handle(RegisterF1TeamCommand command, CancellationToken cancellationToken)
        {
            var _f1Team = F1Team.create(command.officialTeamName, command.teamColor, command.teamPrinciple, command.teamDrivers);
            return _f1TeamRepository.Register(_f1Team, command.storetype);


        }
    }
}
