using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.RegisterF1Team
{
    public sealed record  RegisterF1TeamCommand(string officialTeamName, string teamColor, string teamPrinciple, string[] teamDrivers,string storetype):IRequest<Guid>;
    
}
