using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.CustomerFeedBack;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class CustomerFeedBackService : ICustomerFeedBackService
    {
        #region Constructor
        private readonly AppDbContext _context;
        public CustomerFeedBackService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<List<CustomerFeedBackViewModel>> GetCustomerFeedBackForIndex()
        {
            List<CustomerFeedBackViewModel> customerFeedbacks = await _context.CustomerFeedbacks
                .OrderBy(c => c.Order)
                .Select(c => new CustomerFeedBackViewModel()
                {
                    Order = c.Order,
                    Avatar = c.Avatar,
                    Description = c.Description,
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            return customerFeedbacks;
        }

    
    }
}
