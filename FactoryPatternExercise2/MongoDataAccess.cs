using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Computer", Price = 2304.80},
            new Product (){Name = "TV", Price = 1800.75},
            new Product (){Name = "PlayStation", Price = 550.25},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a Mongo database.");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo database.");
        }
    }
}
