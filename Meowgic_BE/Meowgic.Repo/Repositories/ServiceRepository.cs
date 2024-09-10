using Meowgic.Repositories.Entities;
using Meowgic.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meowgic.Repositories.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly MeowgicDbContext _context;

        public ServiceRepository(MeowgicDbContext context)
        {
            _context = context;

        }
    }
}
