using System;
using System.Collections.Generic;
using System.Linq;
using NeoSample.Models;

namespace NeoSample.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        // place holder for enum
        //public int Group { get; set; }
        public AnimalGroup Group { get; set; }

        // Navigation
        public virtual Zoo Zoo { get; set; }
    }
}
