namespace ListDemo.Models
{
    public class SomeData
    {
        public string Text { get; set; }
        public int Number { get; set; }

        public override string ToString() => $"{Number}: {Text}";
    }
}