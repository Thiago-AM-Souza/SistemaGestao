using BuildingBlocks.Core.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colaboradores.Application.Commands
{
    public class RemoverColaboradorCommand : Command
    {
        public Guid Id { get; private set; }

        public RemoverColaboradorCommand(Guid id)
        {
            Id = id;
        }
    }
}
