using Cajuine.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajuine.DomainModel.Interfaces.Repositories
{
   public class IRestaurantRepository
    {
        void Create(Restaurant restaurant);
        Restaurant Read(Guid post);
        IEnumerable<Restaurant> ReadAll();
        void Update(Restaurant restaurant);
        void Delete(Guid post);
    }
}
