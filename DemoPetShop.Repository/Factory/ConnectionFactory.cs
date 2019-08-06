
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Repository.Factory
{
    public class ConnectionFactory
    {
        protected readonly string connectionString;
        public void CreatConn()
        {
            connectionString = Config.GetConnectionString("ConnectionString");
        }
    }
}
