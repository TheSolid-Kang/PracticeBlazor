namespace BlazorApp1.Data
{
    public class TestClass1
    {
        public TestClass1()
        {
            ClassName = this.GetType().Name;
        }
        public string ClassName { get; set; } = string.Empty;
    }
}
