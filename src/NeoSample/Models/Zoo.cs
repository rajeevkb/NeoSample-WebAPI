using System;
using System.Collections.Generic;
using System.Linq;
using NeoSample.Models;

namespace NeoSample.Models
{

    public class Zoo
    {
        public Zoo()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        // Navigation
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
