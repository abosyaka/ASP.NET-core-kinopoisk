using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesPortal.Data;
using MoviesPortal.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace MoviesPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var movies = from m in _context.Movie select m;
            var movies = from m in _context.Movie.Include(m => m.Director) select m;
            return View(movies.ToList());
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var movie = _context.Movie
                .Include(m => m.MovieDetail)
                .Include(m => m.Director)
                .Include(m => m.Genres)
                .FirstOrDefault(m => m.Id == id);

            if(movie == null)
            {
                return NotFound();
            }

            return View(movie);
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

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1),
                IsEssential = true}
            );

            return LocalRedirect(returnUrl);
        }
    }
}
