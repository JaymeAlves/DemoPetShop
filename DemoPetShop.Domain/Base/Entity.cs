using DemoPetShop.Domain.Base.Interface;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Domain.Base
{
    public class Entity : IEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
    }
}
