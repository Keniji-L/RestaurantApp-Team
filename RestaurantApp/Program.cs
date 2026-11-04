using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<Restaurant> restaurants = new List<Restaurant>
            {
             new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
              new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
              new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
              new Restaurant(4, "Huguosi Snacks", "Snack", 4.2),
              new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8),
            };





            foreach (var item in restaurants)
            {
                Console.WriteLine($"id : {item.getId()} name: {item.getName()} type: {item.getType()} rating: {item.getRating()}");
            }

            double avg = restaurants.Average(r => r.getRating());
            Console.WriteLine($"จำนวนร้านทั้งหมด :{restaurants.Count}");
            Console.WriteLine($"คะแนนเฉลี่ยร้านทั้งหมด :{avg}");


            Console.WriteLine();


            // --- feature/good-rating ---
            // กรองเฉพาะร้านที่มีคะแนนตั้งแต่ 4.5 ขึ้นไป
            var goodRatingRestaurants = restaurants.Where(r => r.getRating() >= 4.5).ToList();


            Console.WriteLine("--- ร้านที่มีคะแนนตั้งแต่ 4.5 ขึ้นไป ---");
            foreach (var item in goodRatingRestaurants)
            {
                Console.WriteLine($"id : {item.getId()} name: {item.getName()} type: {item.getType()} rating: {item.getRating()}");
            }
            Console.WriteLine($"จำนวนร้านที่มีคะแนนดี :{goodRatingRestaurants.Count}");


        }
    }


    class Restaurant
    {
        private int id;
        private String name;
        private String type;
        private double rating;




        public Restaurant(int id, String name, String type, double rating)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.rating = rating;
        }
        public int getId() { return id; }


        public String getName() { return name; }
        public String getType() { return type; }
        public double getRating() { return rating; }
    }
}