using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
     public class RestaurantsMenu
    {
      public string Name  { get; set; }
        private double price;
        private int quality;
        public string Category { get; set; }
        public double Price 
        {
            get{ return price; }
            set
            {
                if (price!= value)
                {
                    price = value;
                }
            }
               
        }
        
        public int quantity
        {
            get { return quality; }
           set
            {
              quality = value;
            }
        }
        
        //public RestaurantsMenu(String name, int category, double price)
        //{
        //    Name = name;
        //   // Price = price;
        //   // Category = category;
        //}
     

    }
}
