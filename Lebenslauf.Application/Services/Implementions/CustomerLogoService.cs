using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.CustomerLogo;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Application.Services.Implementions
{
    public class CustomerLogoService : ICustomerLogoService
    {
        private readonly AppDbContext _context;
        public CustomerLogoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerLogoListViewModel>> GetCustomerLogoForIndexPage()
        {
            return await _context.CustomerLogos
                .OrderBy(c => c.Order)
                .Select(c => new CustomerLogoListViewModel()
                {
                    Id = c.Id,
                    Link = c.Link,
                    Logo = c.Logo,
                    LogoAlt = c.LogoAlt,
                    Order = c.Order,
                })
                .ToListAsync();
        }

        public async Task<CustomerLogo> GetCustomerLogoById(long id)
        {
            return await _context.CustomerLogos.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<CreateOrEditCustomerLogoViewModel> FillCreateOrEditCustomerLogoViewModel(long id)
        {
            if (id == 0) return new CreateOrEditCustomerLogoViewModel() { Id = 0 };

            var logo = await GetCustomerLogoById(id);
            if (logo == null) return new CreateOrEditCustomerLogoViewModel() { Id = 0 };

            return new CreateOrEditCustomerLogoViewModel()
            {
                Id = logo.Id,
                Link = logo.Link,
                Logo = logo.Logo,
                LogoAlt = logo.LogoAlt,
                Order = logo.Order
            };
        }

        public async Task<bool> CreateOrEditCustomerLogo(CreateOrEditCustomerLogoViewModel logo)
        {
            if (logo.Id == 0)
            {
                var newLogo = new CustomerLogo()
                {
                    Link = logo.Link,
                    Logo = logo.Logo,
                    LogoAlt = logo.LogoAlt,
                    Order = logo.Order
                };
                await _context.CustomerLogos.AddAsync(newLogo);
                await _context.SaveChangesAsync();
                return true;
            }

            var currentLogo = await GetCustomerLogoById(logo.Id);
            if (currentLogo == null) return false;

            currentLogo.Link = logo.Link;
            currentLogo.LogoAlt = logo.LogoAlt;
            currentLogo.Order = logo.Order;

            if (!string.IsNullOrEmpty(logo.Logo))
            {
                currentLogo.Logo = logo.Logo;
            }

            _context.CustomerLogos.Update(currentLogo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCustomerLogo(long id)
        {
            var logo = await GetCustomerLogoById(id);
            if (logo == null) return false;

            _context.CustomerLogos.Remove(logo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}