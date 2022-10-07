using System;
using System.Collections.Generic;

#nullable disable

namespace DesignPatterns.Models.Data
{
    public partial class Beer
    {
        public int BeerId { get; set; }
        public string BeerName { get; set; }
        public string BeerStyle { get; set; }
        public Guid BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
