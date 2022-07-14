namespace VideoRentalStore.Core.Entities
{
    public class Costumer : BaseEntity
    {
        public Costumer (string name, string phone, string address){
            Name = name;
            Phone = phone;
            Address = address;
        }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
    }
}