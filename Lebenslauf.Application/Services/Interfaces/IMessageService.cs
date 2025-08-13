using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.Message;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IMessageService
    {
        Task<bool> CreateMessage(CreateMessageViewModel message);
    }
}
