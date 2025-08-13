using Lebenslauf.Application.Services.Interfaces;
using Lebenslauf.Domain.ViewModels.Message;
using Microsoft.AspNetCore.Mvc;

namespace Lebenslauf.Web.Controllers
{
    public class ContactController : Controller
    {


        #region Constructor
        private readonly IMessageService _messageService;
        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        #endregion


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CreateMessageViewModel message)
        {
            if (!ModelState.IsValid)
            {
                return View(message);
            }

            var result = await _messageService.CreateMessage(message);

            return RedirectToAction("Index");
        }
    }
}
