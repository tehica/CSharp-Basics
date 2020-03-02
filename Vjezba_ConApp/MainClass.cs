using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Reflection;


public class MainClass
{
    public static int var1 = 0;
    public static int[] IntArr = new int[] { 0, 1, 2, 3, 4 };
    public static Random rnd = new Random();

    static void Main(string[] args)
    {

        Cust2 customer1 = new Cust2()
        {
            Id = 101,
            Name = "Tom",
            gender = "Male"
        };

        Cust2 customer2 = new Cust2()
        {
            Id = 102,
            Name = "Toni",
            gender = "Male"
        };

        Cust2 customer3 = new Cust2()
        {
            Id = 103,
            Name = "Teo",
            gender = "Male"
        };

        Cust2 customer4 = new Cust2()
        {
            Id = 104,
            Name = "Filip",
            gender = "Male"
        };

        Cust2 customer5 = new Cust2()
        {
            Id = 105,
            Name = "Ivana",
            gender = "Female"
        };
        
        Stack<Cust2> stackCustomers = new Stack<Cust2>();
        stackCustomers.Push(customer1);
        stackCustomers.Push(customer2);
        stackCustomers.Push(customer3);
        stackCustomers.Push(customer4);
        stackCustomers.Push(customer5);

        Cust2 c1 = stackCustomers.Peek();
        Console.WriteLine(c1.Id + " - " + c1.Name );
        Console.WriteLine("Items left in the stack: {0}", stackCustomers.Count);

        Console.ReadLine();
    }
}
