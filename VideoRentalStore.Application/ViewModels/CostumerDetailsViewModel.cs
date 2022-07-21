namespace VideoRentalStore.Application.ViewModels
{
    public class CostumerDetailsViewModel
    {
        public CostumerDetailsViewModel(int id, string name, string phone, string address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}