using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    public class ReviewList : IItemList
    {

        public List<Review> reviews = new List<Review>();
        double avgScore;


        public void GetLeadersByProperty(string property, int numLeaders)
        {

            throw new NotImplementedException();

        }


        public double AggregateScore()
        {
            //reviews = reviews.OrderBy(x => x.GetType().GetProperty("")
            //var aggScore = from review in reviews

            double netScore = reviews.Sum(item => item.Rating);
            avgScore = netScore / reviews.Count;


            return avgScore;
        }

        public void printReviews()
        {
            if (reviews.Any() == false)
            {
                Console.WriteLine("There are no reviews for this restaurant");
            }
            else
            {
                foreach (Review rev in reviews)
                {
                    rev.displayInfo();
                }
            }
        }

        public void AddReview()
        {
            Review newReview = new Review();

            string input;
            Console.WriteLine("Adding new review");
            bool validRating = false;

            
           
            Console.WriteLine("Reviewer Name?");
            input = Console.ReadLine().ToString();
            newReview.ReviewerName = input;

            Console.WriteLine("Rating out of 5 (1-5)");

            while (validRating == false)
            {
                input = Console.ReadLine();
                if ((Convert.ToDouble(input) >= 1) & (Convert.ToDouble(input) <= 5))
                {
                    validRating = true;
                    newReview.Rating = Convert.ToDouble(input);
                }
                else
                {
                    Console.WriteLine("Please enter a valid rating between 1 and 5");
                }
            }

            
            Console.WriteLine("Additional feedback, comments, experience etc.:");
            input = Console.ReadLine().ToString();
            newReview.Description = input;


            reviews.Add(newReview);
        }

    }
}

