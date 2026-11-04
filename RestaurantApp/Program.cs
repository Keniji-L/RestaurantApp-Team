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
            Console.WriteLine($"คะแนนเฉลี่ยร้านทั้งหมด :{avg:F2}");

            // เรียกใช้ฟังก์ชัน ShowSummary เพื่อแสดงร้านที่คะแนนสูงสุดและต่ำสุด
            ShowSummary(restaurants);
        }

        public static void ShowSummary(List<Restaurant> list)
        {
            if (list == null || list.Count == 0) return;

            Restaurant maxRest = list[0];
            Restaurant minRest = list[0];

            foreach (var item in list)
            {
                if (item.getRating() > maxRest.getRating())
                {
                    maxRest = item;
                }
                if (item.getRating() < minRest.getRating())
                {
                    minRest = item;
                }
            }

            Console.WriteLine("\n--- ผลสรุปคะแนนร้านอาหาร ---");
            Console.WriteLine($"ร้านที่คะแนนสูงสุด: {maxRest.getName()} ({maxRest.getRating()} คะแนน)");
            Console.WriteLine($"ร้านที่คะแนนต่ำสุด: {minRest.getName()} ({minRest.getRating()} คะแนน)");
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