using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.GetF1Team
{
    public record  GetF1TeamQuery(Guid id,string StoreType):IRequest<F1Team>
    {
    }
}
