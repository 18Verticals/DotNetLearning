namespace AbstractionUsingInterface
{
    /// <summary>
    /// An interface is a good choice when you know a method has to be there, but it can be implemented 
    /// DIFFERENTLY by independent derived classes.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle();
            shape1.Draw();  // Output: Drawing a Circle.
            Console.ReadLine();
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
