
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;

namespace CleanArchitecture.Services
{
    public class CarsServices : ICarServices
    {

        private readonly IRepository<Cars> _repository;
        public CarsServices(IRepository<Cars> repository)
        {
            _repository = repository;
        }
        public async ValueTask<Cars> Create(Cars car)
        {
            return await _repository.AddAsync(car);
        }

    }
}
