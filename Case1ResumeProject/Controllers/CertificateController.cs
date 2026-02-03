using Case1ResumeProject.Context;
using Case1ResumeProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.Controllers
{
    public class CertificateController : Controller
    {
        private readonly ResumeContext _context;

        public CertificateController(ResumeContext context)
        {
            _context = context;
        }
        public IActionResult CertificateList()
        {
            var values = _context.Certificates.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCertificate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCertificate(Certificate certificate)
        {
            _context.Certificates.Add(certificate);
            _context.SaveChanges();
            return RedirectToAction("CertificateList");
        }
        [HttpGet]
        public IActionResult UpdateCertificate(int id)
        {
            var value = _context.Certificates.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCertificate(Certificate certificate)
        {
            _context.Certificates.Update(certificate);
            _context.SaveChanges();
            return RedirectToAction("CertificateList");
        }
        public IActionResult DeleteCertificate(int id)
        {
            var value = _context.Certificates.Find(id);
            _context.Certificates.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("CertificateList");
        }
    }
}
