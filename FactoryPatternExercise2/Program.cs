using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use?");
            Console.WriteLine("Enter List, SQL, or Mongo");
            string response = Console.ReadLine();
            IDataAccess database = DataAccessFactory.GetDataAccessType(response);
            var productList = database.LoadData();
            foreach (var item in productList)
            {
                Console.WriteLine($"Name: {item.Name} | Price: { item.Price}");
            }
            database.SaveData();
        }
    }
}
