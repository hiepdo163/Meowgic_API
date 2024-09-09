using Meowgic.Repositories.Entities;
using Meowgic.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meowgic.Repositories.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MeowgicDbContext _context;

        public AccountRepository(MeowgicDbContext context)
        {
            _context = context;

        }
    }
}
