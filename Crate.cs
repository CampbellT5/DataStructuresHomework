using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Crate
    {
        public string Id { get; set; }

        public double Price { get; set; }


        private int id = 0000001;
        
        
        public Crate()
        {
            Id = id++.ToString();


            double price = new Random().Next(50,501);
            Price = price;
            
        }
    }
}
