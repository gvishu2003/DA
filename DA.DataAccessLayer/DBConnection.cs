﻿using System.Data.SqlClient;
using System.Data.EntityClient;
namespace DA.DataAccessLayer
{
    static class DBConnection
    {
        public static string ConnectionString()
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = @"ATBLR936\SQLEXPRESS"; //sqlBuilder.DataSource = @"ATBLR357\sqlexpress";
            sqlBuilder.InitialCatalog = "DA";
            sqlBuilder.IntegratedSecurity = true;
            //sqlBuilder.UserID = "sa";
            //sqlBuilder.Password = "Admin@123";

            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = "System.Data.SqlClient";

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.

            entityBuilder.Metadata = @"res://*/DAModel.csdl|res://*/DAModel.ssdl|res://*/DAModel.msl";
            return entityBuilder.ToString();

        }

    }
}
