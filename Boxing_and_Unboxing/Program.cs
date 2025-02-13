using System.Collections;

namespace Boxing_and_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            object obj = num;     //Boxing 
            int i = (int)obj;     //Unboxing
            ArrayList arrayList = new ArrayList();
            arrayList.Add(i);
            int k = (int)arrayList[0];
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
