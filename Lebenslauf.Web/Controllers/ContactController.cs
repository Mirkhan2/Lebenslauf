using GoogleReCaptcha.V3.Interface;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Message;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lebenslauf.Web.Controllers
{
    public class ContactController : Controller
    {
        #region Constructor
        private readonly IMessageService _messageService;
        private readonly ICaptchaValidator _captchaValidator;
        private readonly IInformationService _informationService; // اضافه شد

        public ContactController(IMessageService messageService, ICaptchaValidator captchaValidator, IInformationService informationService)
        {
            _messageService = messageService;
            _captchaValidator = captchaValidator;
            _informationService = informationService; // اضافه شد
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // اطلاعات را از دیتابیس می‌گیریم و به ViewData می‌دهیم تا ویو کرش نکند
            ViewData["Information"] = await _informationService.GetInformation();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CreateMessageViewModel message)
        {
            // باید اینجا هم اطلاعات را پاس بدهیم تا در صورت خطا، صفحه دوباره کرش نکند
            ViewData["Information"] = await _informationService.GetInformation();

            if (!await _captchaValidator.IsCaptchaPassedAsync(message.Captcha))
            {
                ViewData["FormSubmitResult"] = false;
                return View(message);
            }
            if (!ModelState.IsValid)
            {
                return View(message);
            }

            var result = await _messageService.CreateMessage(message);

            if (result)
            {
                ViewData["FormSubmitResult"] = true;
            }

            return View(); // تغییر کرد: برای نمایش پیام موفقیت نباید Redirect کنیم
        }
    }
}