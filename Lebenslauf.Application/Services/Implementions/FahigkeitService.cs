using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Fahigkeit;
using Lebenslauf.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lebenslauf.Application.Services.Implementions
{
    public class FahigkeitService : IFahigkeitService
    {
        private readonly AppDbContext _context;
        public FahigkeitService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<FahigkeitViewModel>> GetAllFahigkeits()
        {
            return await _context.Fahigkeits
                .OrderBy(s => s.Order)
                .Select(s => new FahigkeitViewModel()
                {
                    Id = s.Id,
                    Order = s.Order,
                    Percent = s.Percent,
                    Title = s.Title
                }).ToListAsync();
        }

        public async Task<Fahigkeit> GetFahigkeitById(long id)
        {
            return await _context.Fahigkeits.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<CreateOrEditFahigkeitViewModel> FillCreateOrEditFahigkeitViewModel(long id)
        {
            if (id == 0) return new CreateOrEditFahigkeitViewModel() { Id = 0 };

            var skill = await GetFahigkeitById(id);
            if (skill == null) return new CreateOrEditFahigkeitViewModel() { Id = 0 };

            return new CreateOrEditFahigkeitViewModel()
            {
                Id = skill.Id,
                Title = skill.Title,
                Percent = skill.Percent,
                Order = skill.Order
            };
        }

        public async Task<bool> CreateOrEditFahigkeit(CreateOrEditFahigkeitViewModel skill)
        {
            if (skill.Id == 0)
            {
                var newSkill = new Fahigkeit()
                {
                    Title = skill.Title,
                    Percent = skill.Percent,
                    Order = skill.Order
                };
                await _context.Fahigkeits.AddAsync(newSkill);
                await _context.SaveChangesAsync();
                return true;
            }

            var currentSkill = await GetFahigkeitById(skill.Id);
            if (currentSkill == null) return false;

            currentSkill.Title = skill.Title;
            currentSkill.Percent = skill.Percent;
            currentSkill.Order = skill.Order;

            _context.Fahigkeits.Update(currentSkill);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteFahigkeit(long id)
        {
            var skill = await GetFahigkeitById(id);
            if (skill == null) return false;

            _context.Fahigkeits.Remove(skill);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}