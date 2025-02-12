using System.Collections;
using System.ComponentModel;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array_and_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            //Array is STRONGLY typed. This means that an array can store only specific type of items/elements.
            //Array can contain FIXED number of items.

            int[] array;

            array = new int[10];

            array[0] = 1;

            //array[1] = "Happy"; // Not possible cos of STRONGLY typed

            //ArrayList
            //ArrayList can store ANY type of items\elements
            ArrayList arrayList;
            arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Happy");
        }
    }
}
