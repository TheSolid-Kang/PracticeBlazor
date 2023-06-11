namespace BlazorApp1.Data
{
    public class TestClass2
    {
        public TestClass2()
        {
            ClassName = this.GetType().Name;
        }

        public string ClassName { get; set; } = string.Empty;
    }
}
