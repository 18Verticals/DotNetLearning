using System.Data.Common;
using System.Reflection;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Out_Ref_Parameter
{
    /// <summary>
    /// difference between “out” and “ref” parameters
    /// </summary>

    //By using ref and out keywords we can pass parameters by reference.
    //When you want to return more than one values from a method then you can use out and ref parameters.

    //use ref parameter when you want to modify a value
    //and out parameter when you want to get a new value from the called method.

    internal class Program
    {
        static void Main(string[] args)
        {
            int a; //No need to initialize out parameter before passing it
            int b = 5; //Must initialize ref parameter else error

            WithRefOut obj = new WithRefOut();
            int x = obj.Update(out a, ref b);
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
    public class WithRefOut
    {
        public int Update(out int c, ref int d)
        {
            c = 100; //Out parameter must be initialized before returning. Ref parameter initialization is not necessary
            return c + d;
        }
    }
}
