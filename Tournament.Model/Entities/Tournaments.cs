using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Model.Entities
{
    public class Tournaments
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string? Type { get; set; }
        public string? Venue { get; set; }


        public Tournaments(Guid id, string description, string type, string venue)
        {
            Id = id;
            Description = description;
            Type = type;
            Venue = venue;
        }
    }

    
}
