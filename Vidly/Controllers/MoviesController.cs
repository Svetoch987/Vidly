using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
                _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.Admin))
                return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.Admin)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Save(Movie movie, HttpPostedFileBase imageFile)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                movie.MovieImageId = CreateMovieImage(imageFile);
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.NumberAvailable = movie.NumberAvailable;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.Description = movie.Description;
                movieInDb.DateAdded = DateTime.Now;
                UpdateMovieImage(movieInDb.Id, imageFile);
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            var movieImage = _context.MovieImages.Single(m => m.Id == movie.MovieImageId);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList(),
                MovieImage = movieImage
            };
            return View("MovieForm", viewModel);

        }

        public ActionResult Description(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            var movieImage = _context.MovieImages.Single(m => m.Id == movie.MovieImageId);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList(),
                MovieImage = movieImage
            };

            return View("Description", viewModel);
        }

        private int CreateMovieImage(HttpPostedFileBase imageFile)
        {
            var movieImage = new MovieImage();

            using (var ms = new MemoryStream())
            {
                imageFile.InputStream.CopyTo(ms);
                movieImage.Image = ms.ToArray();
            }

            _context.MovieImages.Add(movieImage);
            _context.SaveChanges();

            _context.Entry(movieImage).GetDatabaseValues();

            return movieImage.Id;

        }

        private void UpdateMovieImage(int movieId, HttpPostedFileBase imageFile)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == movieId);
            var movieImage = _context.MovieImages.SingleOrDefault(i => i.Id == movie.MovieImageId);

            using (var ms = new MemoryStream())
            {
                imageFile.InputStream.CopyTo(ms);
                movieImage.Image = ms.ToArray();
            }

            _context.SaveChanges();
        }
    }
}