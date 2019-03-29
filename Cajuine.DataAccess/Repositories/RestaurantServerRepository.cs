using Cajuine.DomainModel.Entities;
using Cajuine.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajuine.DataAccess.Repositories
{
    class RestaurantServerRepository : IRestaurantRepository
    {
        public void Create(Restaurant restautant)
        {
            throw new NotImplementedException();


            public void Delete(Guid restaurant Id)
            {
                throw new NotImplementedException();
            }

            public Restaurant Read(Guid restaurantId)
            {
                SqlConnection sqlConnection = new SqlConnection(Cajuine
                    .DataAccess.Properties.Settings.Default.DbConnectionString);

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"select * from Restaurant where id = '{restaurantId}'";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                Restaurant restaurant = new Restaurant
                {
                    Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                    Name = sqlDataReader["Name"].ToString(),
                    Address = sqlDataReader["Address"].ToString(),
                    PhotoUrl = sqlDataReader["PhotoUrl"].ToString()
                };

                return restaurant;
            }

            public IEnumerable<Restaurant> ReadAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Restaurant restaurant)
            {
                throw new NotImplementedException();
            }
        }
    }
}