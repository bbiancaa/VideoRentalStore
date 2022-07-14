namespace VideoRentalStore.Core.Entities
{
    public class Movie : BaseEntity
    {
        public Movie (string name, string description, string genre)
        {
            Name = name;
            Description = description;
            Genre = genre;
            Booked = false;
            RegisterDate = DateTime.Now;
        }
        public string Name { get; private set; }
        public string Description {get; private set;}
        public string Genre {get; private set;}
        public bool Booked {get; private set;}
        public DateTime RegisterDate {get; private set;}
        public DateTime? BookedDate {get; private set;}
        public DateTime? ReturnDate {get; private set;}
    }
}