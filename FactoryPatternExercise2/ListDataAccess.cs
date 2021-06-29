using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
        }
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Book", Price = 6.50},
            new Product (){Name = "Pen", Price = 1.25},
            new Product (){Name = "Spiral", Price = 3.05},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a List database.");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List database.");
        }

    }
}
