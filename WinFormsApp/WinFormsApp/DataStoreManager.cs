namespace WinFormsApp
{
    public static class DataStoreManager
    {
        // this list is the data source for users
        public static List<User> Users { get; private set; } = new List<User>();

        // this list is the data source for users
        public static List<Book> Books { get; private set; } = new List<Book>();

        private static bool _isSeeded;

        // seeded data, so the app already has a few users when it starts
        public static void Seed()
        {
            if (_isSeeded)
                return;

            Users.Add(new User { Id = 1, UserName = "admin", Password = "admin123" });
            Users.Add(new User { Id = 2, UserName = "john", Password = "john123" });


            for (int i = 1; i <= 1000; i++)
            {
                Books.Add(new Book
                {
                    Id = i,
                    Name = $"Book {i}",
                    Tile = $"Sample Title {i}",
                    ISBN = $"978{i:D10}"
                });
            }

            _isSeeded = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NextUserId()
        {
            if (Users.Count == 0)
                return 1;

            return Users.Max(u => u.Id) + 1;
        }
    }
}
