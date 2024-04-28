using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Core.Data
{
    public interface ISaveChanges
    {
        Task<bool> Commit();
    }
}
