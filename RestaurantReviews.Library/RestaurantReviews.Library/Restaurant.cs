using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    public class Restaurant : IItem
    {
        public struct Location
        {
            int _streetNum;
            string _streetName;
            string _city;
            string _state;
            int _zipcode;

            public int StreetNumber
            {
                get {return _streetNum; }
                set { _streetNum = value; }
            }

            public string StreetName
            {
                get { return _streetName; }
                set { _streetName = value; }
            }

            public string City
            {
                get { return _city; }
                set { _city = value; }
            }

            public string State
            {
                 get { return _state; }
                 set { _state = value; }
            }

            public int Zipcode
            {
                get { return _zipcode; }
                set { _zipcode = value;  }
            }

            public override string ToString()
            {
                return StreetNumber + " " + StreetName + " " + City + "," + State + " " + Zipcode;
            }

        }

        public string RestaurantName { get; set; }
        public string FoodType { get; set; }


        public double AverageRating {
            get { return reviewList.AggregateScore(); }
            set { value = reviewList.AggregateScore(); }
        }

        public Location restaurantLocation = new Location();

        public ReviewList reviewList = new ReviewList();

        public void displayInfo()
        {
            Console.WriteLine(RestaurantName);
            Console.WriteLine(FoodType);
            Console.WriteLine(AverageRating);
            Console.WriteLine(restaurantLocation.ToString() + "\n");
        }
        
        public void DisplayRestaurantReviews()
        {
            reviewList.printReviews();
        }

       

        




    }
}
