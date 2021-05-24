using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesPortal.Data;
using MoviesPortal.Models;

namespace MoviesPortal.Controllers
{
    public class MovieDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MovieDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MovieDetail.Include(m => m.Movie);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MovieDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDetail = await _context.MovieDetail
                .Include(m => m.Movie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieDetail == null)
            {
                return NotFound();
            }

            return View(movieDetail);
        }

        // GET: MovieDetails/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.Set<Movie>(), "Id", "Title");
            return View();
        }

        // POST: MovieDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,BoxOffice,MovieId")] MovieDetail movieDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Set<Movie>(), "Id", "Id", movieDetail.MovieId);
            return View(movieDetail);
        }

        // GET: MovieDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDetail = await _context.MovieDetail.FindAsync(id);
            if (movieDetail == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.Set<Movie>(), "Id", "Title", movieDetail.MovieId);
            return View(movieDetail);
        }

        // POST: MovieDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,BoxOffice,MovieId")] MovieDetail movieDetail)
        {
            if (id != movieDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieDetailExists(movieDetail.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Set<Movie>(), "Id", "Id", movieDetail.MovieId);
            return View(movieDetail);
        }

        // GET: MovieDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDetail = await _context.MovieDetail
                .Include(m => m.Movie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieDetail == null)
            {
                return NotFound();
            }

            return View(movieDetail);
        }

        // POST: MovieDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieDetail = await _context.MovieDetail.FindAsync(id);
            _context.MovieDetail.Remove(movieDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieDetailExists(int id)
        {
            return _context.MovieDetail.Any(e => e.Id == id);
        }
    }
}
