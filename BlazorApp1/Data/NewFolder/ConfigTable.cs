namespace BlazorApp1.Data.NewFolder
{
    public class ConfigTable
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = string.Empty;
        public string Product { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public DateTime WhenBuy { get; set; }
    }

    public class TableCall
    {
        public TableCall()
        {
            Initialize();
        }
        private List<ConfigTable> ConfigTables = new List<ConfigTable>();
        public void Initialize()
        {
            ConfigTables.Add(new ConfigTable() { Id = 1, Name = "가래떡", Product = "음식", Category = "떡", Price = "1000￦", WhenBuy = DateTime.Now });
            ConfigTables.Add(new ConfigTable() { Id = 1, Name = "라면", Product = "음식", Category = "면", Price = "2000￦", WhenBuy = DateTime.Now });
            ConfigTables.Add(new ConfigTable() { Id = 1, Name = "치킨", Product = "음식", Category = "닭", Price = "3000￦", WhenBuy = DateTime.Now });
            ConfigTables.Add(new ConfigTable() { Id = 1, Name = "피자", Product = "음식", Category = "빵", Price = "4000￦", WhenBuy = DateTime.Now });
            ConfigTables.Add(new ConfigTable() { Id = 1, Name = "게토레이", Product = "음식", Category = "음료", Price = "5000￦", WhenBuy = DateTime.Now });
        }
        public List<ConfigTable> GetConfigTables()
        {
            return ConfigTables;
        }
    }
}
