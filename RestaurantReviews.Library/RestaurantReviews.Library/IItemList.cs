using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    public interface IItemList
    {

        void LeaderByProperty(object property, List<object> list, int numLeaders);

    }

    public class RestarantList : IItemList
    {
        public void LeaderByProperty(object property, List<object> list, int numLeaders)
        {
            throw new NotImplementedException();
        }
    }

    public class ReviewList : IItemList
    {
        public void LeaderByProperty(object property, List<object> list, int numLeaders)
        {
            throw new NotImplementedException();
        }
    }
}
