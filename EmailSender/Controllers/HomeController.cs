using EmailSender.Models;
using EmailSender.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmailSender.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;

        public HomeController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var reciever = "joel.n.wanjala@gmail.com";
            var subject = "Test email";
            var body = "This is a test email from MVC email sending application";
            await _emailSender.SendEmailAsync(reciever, subject, body);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
