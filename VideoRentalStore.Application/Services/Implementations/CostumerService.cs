using VideoRentalStore.Application.InputModels;
using VideoRentalStore.Application.Services.Interfaces;
using VideoRentalStore.Application.ViewModels;
using VideoRentalStore.Core.Entities;
using VideoRentalStore.Infrastructure.Persistence.Repositories;

namespace VideoRentalStore.Application.Services.Implementations
{
    public class CostumerService : ICostumerService
    {
        private readonly VideoRentalStoreDbContext _dbContext;
        public CostumerService(VideoRentalStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /*public int Create(NewCostumerInputModel inputModel)
         {
             var costumer = new Costumer(inputModel.Name, inputModel.Description, inputModel.Genre);
             _dbContext.Costumers.Add(costumer);

             return costumer.Id;
         }

         public void Delete (int id)
         {
             var costumer = _dbContext.Movie.SingleOrDefault(c => c.Id == id);
             costumer.Delete();
            //_dbContext.Movies.Delete
         }

         public List<CostumerViewModel> GetAll(string query)
         {
             var costumers = _dbContext.Costumers;
             var costumersViewModel = costumers.Select(c => new CostumerViewModel( c.Name, c.Booked)).ToList();
             return costumersViewModel;
         }

         public CostumerDetailsViewModel GetById(int id)
         {
             var costumer = _dbContext.Costumer.SingleOrDefault(m => m.Id == id);
             var costumerDetailsViewModel = new CostumerDetailsViewModel(
                 costumer.Id,
                 costumer.Name,
                 costumer.Description,
                 costumer.Genre,
                 costumer.Booked
             );
             return movieDetailsViewModel;
         }

         public void Update(UpdateCostumerInputModel inputModel)
         {
             var costumer = _dbContext.Costumer.SingleOrDefault(m => m.Id == inputModel.Id);
             costumer.Update(inputModel.Name, inputModel.Description, inputModel.Genre);
         }*/
    }
}