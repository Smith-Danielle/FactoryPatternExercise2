using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "Bed", Price = 2500.95},
            new Product (){Name = "Pillow", Price = 50.25},
            new Product (){Name = "Sheets", Price = 100.50},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a SQL database.");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL database.");
        }
    }
}
