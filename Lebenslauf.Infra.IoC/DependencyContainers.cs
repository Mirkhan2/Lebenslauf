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
            service.AddScoped<IEducationService, EducationService>();
            service.AddScoped<ICustomerLogoService, CustomerLogoService>();
            service.AddScoped<IErfahrungService, ErfahrungService>();
            service.AddScoped<ISocialMediaService, SocialMediaService>();
            service.AddScoped<IInformationService, InformationService>();
            service.AddScoped<IMessageService, MessageService>();
            service.AddScoped<IFahigkeitService, FahigkeitService>();
            service.AddScoped<IPortfolioService, PortfolioService>();
            service.AddScoped<ICustomerFeedbackService, CustomerFeedbackService>();
        }

    }
}
