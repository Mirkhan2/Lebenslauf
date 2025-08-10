using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.ViewModels.Portfolio;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IPortfolioService
    {
        Task<List<PortfolioViewModel>> GetAllPortfolios();
        Task<List<PortfolioCategoryViewModel>> GetAllPortfolioCategories();
    }
}
