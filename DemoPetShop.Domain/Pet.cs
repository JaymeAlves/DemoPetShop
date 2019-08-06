using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Domain
{
    public class Pet
    {
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public Pet(string species, string breed, string name, float weight)
        {
            Species = species;
            Breed = breed;
            Name = name;
            Weight = weight;
        }
    }
}
