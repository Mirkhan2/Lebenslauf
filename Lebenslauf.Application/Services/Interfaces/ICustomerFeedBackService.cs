using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.CustomerFeedBack;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface ICustomerFeedBackService 
    {
        Task<List<CustomerFeedBackViewModel>> GetCustomerFeedBackForIndex();
    }
}
