namespace VideoRentalStore.Application.Services.Interfaces
{
    public interface ICostumerService
    {
         CostumerDetailsViewModel GetById(int Id);
         List<CostumerViewModel> GetAll(string query);
    }
}