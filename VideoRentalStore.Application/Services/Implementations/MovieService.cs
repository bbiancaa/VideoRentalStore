using VideoRentalStore.Application.InputModels;
using VideoRentalStore.Application.Services.Interfaces;
using VideoRentalStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using VideoRentalStore.Infrastructure.Persistence;
using VideoRentalStore.Core.Entities;

namespace VideoRentalStore.Application.Services.Implementations
{
    public class MovieService : IMovieService
    {
        private readonly VideoRentalStoreDbContext _dbContext;
        public MovieService(VideoRentalStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
         public int Create(NewMovieInputModel inputModel)
         {
             var movie = new Movie(inputModel.Name, inputModel.Description, inputModel.Genre);
             _dbContext.Movies.Add(movie);

             return movie.Id;
         }

         public void Delete (int id)
         {
             var movie = _dbContext.Movie.SingleOrDefault(m => m.Id == id);
             movie.Delete();
            //_dbContext.Movies.Delete
         }

         public List<MovieViewModel> GetAll(string query)
         {
             var movies = _dbContext.Movies;
             var moviesViewModel = movies.Select(m => new MovieViewModel( m.Name, m.Booked)).ToList();
             return moviesViewModel;
         }

         public MovieDetailsViewModel GetById(int id)
         {
             var movie = _dbContext.Movie.SingleOrDefault(m => m.Id == id);
             var movieDetailsViewModel = new MovieDetailsViewModel(
                 movie.Id,
                 movie.Name,
                 movie.Description,
                 movie.Genre,
                 movie.Booked
             );
             return movieDetailsViewModel;
         }

         public void Update(UpdateMovieInputModel inputModel)
         {
             var movie = _dbContext.Movie.SingleOrDefault(m => m.Id == inputModel.Id);
             movie.Update(inputModel.Name, inputModel.Description, inputModel.Genre);
         }
    }
}