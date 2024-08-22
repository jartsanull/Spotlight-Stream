using Spotlight_Stream.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spotlight_Stream.Repositories{
    public interface IMeseRepo{
        Task<Message> GetMessageByIdAsync(long id);
        Task<List<Message>> GetMessagesBySenderAsync(string sender);
        Task AddMessageAsync(Message message);
        Task UpdateMessageAsync(Message message);
        Task DeleteMessageAsync(long id);
    }
}