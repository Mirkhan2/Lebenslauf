using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.Models;
using Lebenslauf.Domain.ViewModels.Portfolio;

namespace Lebenslauf.Application.Services.Interfaces
{
    public interface IPortfolioService
    {
        Task<List<PortfolioViewModel>> GetAllPortfolios();
        //Task<List<PortfolioViewModel>> GetAllPortfolios();
        Task<Portfolio> GetPortfolioById(long id);
        Task<CreateOrEditPortfolioViewModel> FillCreateOrEditPortfolioViewModel(long id);
        Task<bool> CreateOrEditPortfolio(CreateOrEditPortfolioViewModel portfolio);
        Task<bool> DeletePortfolio(long id);
        #region Portfolio Category
        //   Task<PortfolioCategory> GetPortfolioCategoryById(long id);
        Task<PortfolioCategory> GetAllPortfolioCategoryById(long id);
        Task<List<PortfolioCategoryViewModel>> GetAllPortfolioCategories();
        Task<CreateOrEditPortfolioCategoryViewModel> FillCreateOrEditPortfolioCategoryViewModel(long id);
        Task<bool> CreateOrEditPortfolioCategory(CreateOrEditPortfolioCategoryViewModel portfolioCategory);
        Task<bool> DeletePortfolioCategory(long id);
        #endregion


    }
}
