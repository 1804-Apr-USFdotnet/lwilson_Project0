using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Library;

namespace RestaurantReviews.Menu
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            RestaurantList listRestaurants = new RestaurantList();
            RestaurantXMLHandler restaurantXMLHandler = new RestaurantXMLHandler();

            listRestaurants = restaurantXMLHandler.ReadListFromXML();

            string input;
            string exitFlag = "!";
            bool exitMenu = false;



            while (exitMenu == false)
            {
                if (listRestaurants.IsRestaurantSelected() == false)
                {
                    Console.WriteLine("1 Select a Restaurant,  2 display all Restaurants, 3 add Restaurant, 4 Search for a Restaurant  , ! = quit \n");

                    input = Console.ReadLine().ToString();
                    Console.WriteLine(input);

                    if (input.Equals(exitFlag))
                    {
                        Console.WriteLine("Quitting");
                        exitMenu = true;

                    }
                    else if (input == "1")
                    {
                        Console.WriteLine(input);
                        Console.WriteLine("Enter a name or partial restaurant name to select");
                        input = Console.ReadLine().ToString();
                        listRestaurants.SelectRestaurant(input);
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Display all Restaurants \n");
                        listRestaurants.DisplayAll();

                    }
                    else if (input == "3")
                    {
                        Console.WriteLine("Add Restaurant \n");
                        listRestaurants.AddRestaurant();
                        restaurantXMLHandler.WriteListToXML(listRestaurants);

                    } else if (input == "4")
                    {
                        Console.WriteLine("Enter the name or partial name of a restaurant to search for");
                        input = Console.ReadLine().ToString();
                        listRestaurants.SearchByName(input);
                    }
                    else
                    {
                        Console.WriteLine(input);
                        Console.WriteLine("select a menu option \n");

                    }
                }

                else if (listRestaurants.IsRestaurantSelected() == true)

                {
                    Console.WriteLine("1 Display Reviews, 2 Review this Restaurant, 3 Return to main menu \n");
                    input = Console.ReadLine().ToString();

                    if (input == "1")
                    {
                        Console.WriteLine("Display Reviews");
                        listRestaurants.DisplayTheseReviews();
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Add Review \n");
                        listRestaurants.AddReviewToThisRestaurant();
                        restaurantXMLHandler.WriteListToXML(listRestaurants);
                    }
                    else if (input == "3")
                    {
                        listRestaurants.DeselectRestaurant();
                        //unselect restaurant
                    }
                    else
                    {
                        Console.WriteLine(input);
                        Console.WriteLine("select a menu option \n");
                    }
                }



            }
        }
    }
}
