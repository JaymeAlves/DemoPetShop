using DemoPetShop.Domain;
using DemoPetShop.Repository.Base;
using DemoPetShop.Repository.Base.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Repository
{
    public class PetRepository : Repository<Pet>
    {
        public PetRepository(IMongoDatabase p_Database) : base(p_Database, "pet")
        {

        }
    }
}
