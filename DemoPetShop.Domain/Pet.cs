using DemoPetShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Domain
{
    [BsonIgnoreExtraElements]
    public class Pet : Entity
    {
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public float Weigth { get; set; }
    }
}
