using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DELEGATES
// _________________________________________________________________________________________________
public delegate void HelloFunctionDelegate(string Message);

// #19
public delegate bool IsPromotable(Employee empl);

// #20
public delegate void SampleDelegate();

public delegate int SampleDelegate_2();

public delegate void SampleDeletage_3(out int Intenger);










// DELEGATES METHODS
// _________________________________________________________________________________________________
public class DelegatesMethods
{
    // used for delegates basics
    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }

    // #19
    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // #20
    public static void SampleMethodOne()
    {
        Console.WriteLine("SampleMethodOne Invoked");
    }
    public static void SampleMethodTwo()
    {
        Console.WriteLine("SampleMethodTwo Invoked");
    }
    public static void SampleMethodThree()
    {
        Console.WriteLine("SampleMethodThree Invoked");
    }

    public static int Method1()
    {
        return 1;
    }
    public static int Method2()
    {
        return 2;
    }

    public static void Method3(out int Number)
    {
        Number = 1;
    }
    public static void Method4(out int Number)
    {
        Number = 2;
    }


}   
