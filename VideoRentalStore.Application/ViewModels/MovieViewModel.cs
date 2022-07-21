namespace VideoRentalStore.Application.ViewModels
{
    public class MovieViewModel
    {
        public MovieViewModel(string name, bool booked)
        {
            Name = name;
            Booked = booked;
        }
         public string Name { get; set; }
         public bool Booked { get; set; }
    }
}