using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantReviews.Library
{
    public interface IEntity
    {
        DateTime Created { get; set; }
        DateTime? Modified { get; set; }
    }
}