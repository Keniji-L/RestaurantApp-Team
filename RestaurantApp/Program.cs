using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
            {
             new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
              new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
              new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
              new Restaurant(4, "Huguosi Snacks", "Snack", 4.2),
              new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8),
            };

        static void Main(string[] args)
        {

            add_restaurant();




            foreach (var item in restaurants)
            {
                Console.WriteLine($"id : {item.getId()} name: {item.getName()} type: {item.getType()} rating: {item.getRating()}");
            }
            
            double avg = restaurants.Average(r => r.getRating());
            Console.WriteLine($"จำนวนร้านทั้งหมด :{restaurants.Count}");
            Console.WriteLine($"คะแนนเฉลี่ยร้านทั้งหมด :{avg}");


            

            
        }
        public static void add_restaurant()
        {
            Console.WriteLine("----กรอกข้อมูลร้าน----");
            Console.Write("ชื่อร้าน :");
            string name  =  Console.ReadLine();
            Console.Write("ประเภท :");
            string type = Console.ReadLine();
            Console.Write("คะแนน :");
            double rating = int.Parse(Console.ReadLine());
            int nextId = restaurants.Count > 0 ? restaurants.Last().getId() + 1 : 1;
            restaurants.Add(new Restaurant(nextId, name, type, rating));
        }
    }

    

    class Restaurant
    {
        private int id;
        private String name;
        private String type;
        private double rating;


        public Restaurant(int id,String name,String type,double rating)
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
