using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Application.Services.Implementions;
using Lebenslauf.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Lebenslauf.Infra.IoC
{
    public class DependencyContainers
    {
        public static  void RegisterService(IServiceCollection service)
        {
            service.AddScoped<IThingIDoService, ThingsIDoService>();
            service.AddScoped<ICustomerFeedBackService, CustomerFeedBackService>();
            service.AddScoped<IEducationService, EducationService>();
            service.AddScoped<ICustomerLogoService, CustomerLogoService>();
            service.AddScoped<IErfahrungService, ErfahrungService>();
            service.AddScoped<IPortfolioService, PortfolioService>();
            service.AddScoped<ISocialMediaService, SocialMediaService>();
            service.AddScoped<IInformationService, InformationService>();
            service.AddScoped<IMessageService , MessageService>();





        }

    }
}
