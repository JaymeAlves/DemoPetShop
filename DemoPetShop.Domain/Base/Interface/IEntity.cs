using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Domain.Base.Interface
{
    public interface IEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
    }
}
