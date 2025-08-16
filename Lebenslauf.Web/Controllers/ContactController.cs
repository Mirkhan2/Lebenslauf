using GoogleReCaptcha.V3.Interface;
using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Message;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Controllers
{
    public class ContactController : Controller
    {


        #region Constructor
        private readonly IMessageService _messageService;
        private readonly ICaptchaValidator _captchaValidator;
        public ContactController(IMessageService messageService , ICaptchaValidator captchaValidator)
        {
            _messageService = messageService;
            _captchaValidator = captchaValidator;
        }
        #endregion


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CreateMessageViewModel message)
        {
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

            return RedirectToAction("Index");
        }
    }
}
