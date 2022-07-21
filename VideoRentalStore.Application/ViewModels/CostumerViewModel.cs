namespace VideoRentalStore.Application.ViewModels
{
    public class CostumerViewModel
    {
        public CostumerViewModel (string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}