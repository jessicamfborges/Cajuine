using Cajuine.DomainModel.Entities;
using Cajuine.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajuine.DomainService
{
  public  class RestaurantService
    {

        private IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public void CreateRestaurant(Restaurant restaurant)
        {
            _restaurantRepository.Create(restaurant);
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            _restaurantRepository.Update(restaurant);
        }

        public void DeleteRestaurant(Guid restaurantId)
        {
            _restaurantRepository.Delete(restaurantId);
        }

        public Restaurant GetProfile(Guid restaurantId)
        {
            return _restaurantRepository.Read(restaurantId);
        }

        public IEnumerable<Restaurant> SearchRestaurantByName(string name)
        {
            return _restaurantRepository.ReadAll()
                .Where(p => p.Name.ToLower().Contains(name.ToLower()));
        }


    }
}
