namespace Static_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyCollege.collegeName);
            MyCollege.CollegeBranch();

            Console.ReadLine();
        }
    }

    //A static class is a class which object cannot be created, and which cannot be inherited.
    //Static classes are used as containers for static members like methods, constructors and others.
    public static class MyCollege
    {
        //static fields 
        public static string collegeName;
        public static string address;

        //static constructor 
        static MyCollege()
        {
            collegeName = "XYZ College";
        }

        //static method 
        public static void CollegeBranch()
        {
            Console.WriteLine("IT");
        }

    }
}
