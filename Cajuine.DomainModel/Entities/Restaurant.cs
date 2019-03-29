using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajuine.DomainModel.Entities
    
{
    public class Restaurant : EntityBase
    {
       
            public string Name { get; set; }
            public string Description { get; set; }
            public string Address { get; set; }
            public string PhotoUrl { get; set; }
            public virtual ICollection<Restaurant> Receita { get; set; }
            public string Country { get; set; }

            //public Restaurant()
            //{
            //    Receita = new List<Restaurant>();
            //}

            //public override bool IsValid()
            //{
            //    return IsNotEmptyRestaurantAddress.IsValid(this);
            //}
        }
    }