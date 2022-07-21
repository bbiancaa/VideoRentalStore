namespace VideoRentalStore.Application.ViewModels
{
    public class MovieDetailsViewModel
    {
        public MovieDetailsViewModel(int id, string name, string description, string genre, bool booked)
        {
            Id = id;
            Name = name;
            Description = description;
            Genre = genre;
            Booked = booked;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
         public bool Booked { get; set; }
    }
}