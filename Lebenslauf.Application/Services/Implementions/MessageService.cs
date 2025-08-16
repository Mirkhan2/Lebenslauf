using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Security;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Message;
using Lebenslauf.Infra.Data.Context;

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
        //aza

        public  async Task<bool> CreateMessage(CreateMessageViewModel message)
        {
            Message newMessage = new Message()
            {
                Email = message.Email.SanitizeText(),
                //    Id = message.Id,
                Name = message.Name.SanitizeText(),
                Text = message.Text.SanitizeText(),
            };
            await _context.AddAsync(newMessage);
            await _context.SaveChangesAsync();

            return true;
         
        }
    }
}
