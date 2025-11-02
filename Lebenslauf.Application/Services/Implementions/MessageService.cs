using Lebenslauf.Application.Security;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Message;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class MessageService : IMessageService
    {
        #region COntructor
        private readonly AppDbContext _context;
        public MessageService(AppDbContext context)
        {
            _context = context;
        }


        #endregion
        

        public  async Task<bool> CreateMessage(CreateMessageViewModel message)
        {
            Message newMessage = new Message()
            {
                Email = message.Email.SanitizeText(),
                Name = message.Name.SanitizeText(),
                Text = message.Text.SanitizeText(),
            };
            await _context.AddAsync(newMessage);
            await _context.SaveChangesAsync();

            return true;
         
        }

        public async Task<List<MessageViewModel>> GetAllMessages()
        {
            List<MessageViewModel> messages = await _context.Messages
                .Select(m => new MessageViewModel()
                {
                    Id = m.Id,
                    Email = m.Email,
                    Name = m.Name,
                    Text = m.Text
                })
                .ToListAsync();

            return messages;
        }

        public async Task<bool> DeleteMessage(long id)
        {
            Message message = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);

            if (message == null) return false;

            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
