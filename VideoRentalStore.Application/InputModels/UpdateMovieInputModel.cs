namespace VideoRentalStore.Application.InputModels
{
    public class UpdateMovieInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
    }
}