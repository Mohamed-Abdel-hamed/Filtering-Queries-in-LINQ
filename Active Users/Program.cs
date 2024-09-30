namespace Active_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = CreateUserList();

            var resul=users.Where(x=>x.IsActive).ToList();
             foreach(var user in resul)
            {
                Console.WriteLine($"Id : {user.Id} |"  + 
                    $" Name : {user.Name}");
            }
        }
        public static List<User> CreateUserList()
        {
            return new List<User>
        {
            new User(1, "Alice", true),
            new User(2, "Bob", false),
            new User(3, "Charlie", true),
            new User(4, "David", false),
            new User(5, "Eve", true)
        };
        }

    }
}
