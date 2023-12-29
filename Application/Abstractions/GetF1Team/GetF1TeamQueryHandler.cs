using domain.Interfaces.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.GetF1Team
{
    internal class GetF1TeamQueryHandler : IRequestHandler<GetF1TeamQuery, F1Team>
    {
        private readonly IF1TeamRepository _f1TeamRepository;
        public GetF1TeamQueryHandler(IF1TeamRepository f1TeamRepository) 
        {
            _f1TeamRepository = f1TeamRepository;
        }

        Task<F1Team> IRequestHandler<GetF1TeamQuery, F1Team>.Handle(GetF1TeamQuery request, CancellationToken cancellationToken)
        {
            return _f1TeamRepository.GetById(request.id, request.StoreType); ;
        }
    }
}
