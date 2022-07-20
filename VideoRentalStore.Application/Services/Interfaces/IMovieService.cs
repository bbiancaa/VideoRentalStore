namespace VideoRentalStore.Application.Services.Interfaces
{
    public interface IMovieService
    {
         MovieDetailsViewModel GetById(int Id);
         List<MovieViewModel> GetAll(string query);
    }
}