﻿using Cajuine.DomainModel.Entities;
using Cajuine.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TheSocialNetwork.DataAccess.Repositories
{
    public class ProfileSqlServerRepository : IProfileRepository
    {
        public void Create(Profile profile)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid profileId)
        {
            throw new NotImplementedException();
        }

        public Profile Read(Guid profileId)
        {
            SqlConnection sqlConnection = new SqlConnection(Cajuine
                    .DataAccess.Properties.Settings.Default.DbConnectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select * from Profiles where id = '{profileId}'";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Profile profile = new Profile
            {
                Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                Name = sqlDataReader["Name"].ToString(),
                Birthday = DateTime.Parse(sqlDataReader["Birthday"].ToString()),
                Address = sqlDataReader["Address"].ToString(),
                PhotoUrl = sqlDataReader["PhotoUrl"].ToString()
            };

            return profile;
        }

        public IEnumerable<Profile> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}