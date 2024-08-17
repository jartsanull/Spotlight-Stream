using Microsoft.EntityFrameworkCore;
using Spotlight_Stream.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotlight_Stream.Repositories
{
    public class MessageRepository
    {
        private readonly ApplicationDbContext _context;

        public MessageRepository(ApplicationDbContext context)
        {
            _context = context;
        }


    }
}
