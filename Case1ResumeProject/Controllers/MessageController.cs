using Case1ResumeProject.Context;
using Case1ResumeProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeContext _context;

        public MessageController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var values = _context.Messages.OrderByDescending(x => x.SendDate).ToList();
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }
        [HttpGet]
        public IActionResult MessageDetail(int id)
        {
            var value = _context.Messages.Find(id);
            return View(value);
        }
        public IActionResult MarkAsRead(int id)
        {
            var value = _context.Messages.Find(id);
            value.IsRead = true;
            _context.Messages.Update(value);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }
        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            _context.Messages.Add(message);
            _context.SaveChanges();

            TempData["MessageSuccess"] = "Mesajınız başarıyla gönderildi.";
            return Redirect(Url.Action("Index", "Default")+"#contact");
        }
    }
}
