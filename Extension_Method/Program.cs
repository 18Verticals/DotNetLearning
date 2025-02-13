namespace Extension_Method
{
    //Extension method concept allows you to add new methods in the existing class,
    //WITHOUT MODIFYING the source code of the original class.
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "HelloWorld";
            string left = test.Substring(0, 5);
            Console.WriteLine(left); // Hello

            string right = test.RightSubstring(5);
            Console.WriteLine(right); // World
            Console.ReadLine();
        }
    }
    public static class StringExtensions
    {
        public static string RightSubstring(this String s, int count)
        {
            return s.Substring(s.Length - count, count);
        }
    }
}
