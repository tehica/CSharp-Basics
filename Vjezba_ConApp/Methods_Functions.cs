using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Methods
{

    public static int SameMemoryLocation(ref int a)
    {
        a = 100;

        return a;
    }

    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
        Product = FN * SN;
    }

    public static void ParamsMethods(params int[] Numbers)
    {
        Console.WriteLine("There are {0} elements.", Numbers.Length);

        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }

    public static void ParamsMethods2(params object[] elements)
    {
        Console.WriteLine("There are {0} elements.", elements.Length);

        foreach (object e in elements)
        {
            Console.WriteLine(e);
        }
    }

    public static void Add(int a)
    {
        Console.WriteLine(a + 10);
    }

    public static void Add(float a)
    {
        Console.WriteLine(a + 1);
    }

    
    
    
}


    