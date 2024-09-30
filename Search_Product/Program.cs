namespace Search_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = CreateUserList();
            var result= SearchProducts(products,"TV", "Elec", 80);
            foreach (var item in result)
            {
                Console.WriteLine($"Name : {item.Name} | Category : {item.Category} | Price : {item.Price}");
            }
        }
        public static List<Product> SearchProducts(List<Product> products, string searchTerm, string category, decimal? minPrice)
        {
            var query = products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(product => product.Name.Contains(searchTerm));
            }

            if (!string.IsNullOrWhiteSpace(category))
            {
                query = query.Where(product => product.Category == category);
            }

            if (minPrice.HasValue)
            {
                query = query.Where(product => product.Price >= minPrice.Value);
            }

            return query.ToList();
        }
        public static List<Product> CreateUserList()
        {
            return new List<Product>
            {
                new Product("Labtop","Elec",1000),
                new Product("TV","Elec",800),
                new Product("Phone","IOS",4000),

            };
        }

    }
}
