using System;

namespace AccessModifiers
{
    class PropertyClass
    {
        public string Name;
        //{ get; set; }
        public decimal Price;
        //{ get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var item = new SaleItem { Name = "Shoes", Price = 19.95m };
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }
    }
}
