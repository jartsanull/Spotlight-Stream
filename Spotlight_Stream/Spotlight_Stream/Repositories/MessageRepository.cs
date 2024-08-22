using Microsoft.EntityFrameworkCore;
using Spotlight_Stream.Data;
using Spotlight_Stream.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotlight_Stream.Repositories{
    public class MessageRepository : IMeseRepo
    {
        
        private readonly ApplicationDbContext _context;

        public MessageRepository(ApplicationDbContext context){
            _context = context;
        }

        public async Task<Message> GetMessageByIdAsync(long id){
            return await _context.Messages.FindAsync(id);
        }


        public async Task<List<Message>> GetMessagesBySenderAsync(string sender){
            return await _context.Messages.Where(m => m.Sender == sender).
                ToListAsync();
        }

        public async Task AddMessageAsync(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMessageAsync(Message message)
        {
            _context.Messages.Update(message);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMessageAsync(long id)
        {
            var message = await _context.Messages.FindAsync(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
                await _context.SaveChangesAsync();
            }
        }
    }

}

