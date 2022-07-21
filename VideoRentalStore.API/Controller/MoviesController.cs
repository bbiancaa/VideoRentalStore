using Microsoft.AspNetCore.Mvc;
using VideoRentalStore.Application.Services.Interfaces;
namespace VideoRentalStore.API.Controller
{
    //[Route("api/movies")]
    //public class MoviesController : ControllerBase
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
    }
}