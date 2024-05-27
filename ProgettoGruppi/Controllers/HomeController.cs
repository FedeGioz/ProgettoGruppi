using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProgettoGruppi.Areas.Identity.Data;
using ProgettoGruppi.Data;
using ProgettoGruppi.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace ProgettoGruppi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ProgettoGruppiDbContext _context;

        public HomeController(
            ILogger<HomeController> logger,
            UserManager<ApplicationUser> userManager,
            ProgettoGruppiDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
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

        public async Task<IActionResult> Segnala()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null || user.isTechnician)
            {
                // TODO: redirect a pagina visualizzazione tutte segnalazioni se loggato ma tecnico
                return Redirect("/Identity/Account/Login");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Segnala(SegnalazioneModel model)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null || user.isTechnician)
            {
                // TODO: redirect a pagina visualizzazione tutte segnalazioni se loggato ma tecnico
                return Redirect("/Identity/Account/Login");
            }

            if (ModelState.IsValid)
            {
                var segnalazione = new Segnalazione
                {
                    UserId = user.Id,
                    Problema = model.Problema,
                    Luogo = model.Luogo,
                    Priorita = model.Priorita
                };

                _context.Segnalazioni.Add(segnalazione);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> ListaSegnalazioni()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null || !user.isTechnician)
            {
                // Redirect to an appropriate page if the user is not a technician
                return RedirectToAction("Index");
            }

            var segnalazioni = await _context.Segnalazioni.ToListAsync();
            return View(segnalazioni);
        }
    }
}