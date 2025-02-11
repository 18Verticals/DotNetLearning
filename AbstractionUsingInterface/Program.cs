namespace AbstractionUsingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle();
            shape1.Draw();  // Output: Drawing a Circle.
        }
    }
    interface IShape
    {
        //public IShape() // Interface can not have constructor
        //{
        //}
        void Draw();  // By default public abstract method
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }
}
