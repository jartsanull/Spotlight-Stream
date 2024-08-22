using Microsoft.EntityFrameworkCore;
using Spotlight_Stream.Data;
using Spotlight_Stream.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotlight_Stream.Repositories{
    public class MessageRepository : IMeseRepo{
        
        private readonly ApplicationDbContext _context;

        public MessageRepository(ApplicationDbContext context)
        {
            _context = context;
        }


    }
}
