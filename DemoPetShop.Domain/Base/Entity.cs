using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Domain.Base
{
    public class Entity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
    }
}
