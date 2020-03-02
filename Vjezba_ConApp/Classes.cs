using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
// using Vjezba_ConApp;

// ABSTRACT CLASSES
/*
Klasa ne moze biti u isto vrijeme sealed i abstract, mora biti jedno ili drugo ako vec koristimo
- abstract : znaci da se ta klasa koja ima tu kljucnu rijec mora koristiti kao bazna klasa
- sealed : je suprotnost abstract-u
*/

#region AbstClass1
public abstract class AbstClass1
{
    // metode mogu imati abstract klj. rijec, ali nije obavezno
    public abstract void Print();

    public void Print2()
    {
        Console.WriteLine("Print2 method from AbstClass1 (abstract) class.");
    }
}
#endregion


// STUCTS
#region Customer
public struct Customer
{
    private int _id;
    private string _name;
    private string _surname;

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public string Surname
    {
        get { return this._surname; }
        set { this._surname = value; }
    }

    // constructor
    public Customer(int id, string name, string surname)
    {
        this._id = id;
        this._name = name;
        this._surname = surname;
    }

    public void PrintInfoCustomer()
    {
        Console.WriteLine("Customer id: {0} ; Customer name: {1} ; Customer surname: {2}",
                           _id, _name, _surname);
    }

}
#endregion


// INTERFACES
/*
- svaka metoda unutar interface-a po defaultu je public
- ako na klasu napravimo inharitance od interface-a, sve metode unutar interface-a moraju biti u toj klasi
- jedna klasa moze inheritat vise od jednog interface-a
*/

#region ICustomer1 and ICustomer2
interface ICustomer1
{
    void Print1();
}
interface ICustomer2 : ICustomer1
{
    void Print2();
}
#endregion

#region I1 & I2
interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}
#endregion


// CLASSES
#region Complex klasa
public class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public int num1 { get; }

    // metode se ovje pisu u drugoj klasi
    public void Student()
    {
        Console.WriteLine("Toni Musa");
    }


    // metoda koja nije void, koja vraca nesto nakon pozivanja i prima parametre
    public int SumNums(int a, int b)
    {
        return a + b;
    }

    public static void NumOfYears(int a)
    {
        Console.WriteLine("Student ima {0} godina.", a);
    }

    public static void numOutput(ref int a)
    {
        a = 100;
        Console.WriteLine("Vrijednost varijable var1 iz klase Program sada je: " + MainClass.var1);
    }

    public void Calculate(int a, int b, out int Sum, out int Sub)
    {
        Console.WriteLine("Zbroj zadana dva broja je: {0}", Sum = a + b);
        Console.WriteLine("Razlika brojeva je: {0}", Sub = a - b);
    }

    // koji god array da proslijedimo ovoj metodu
    // ona ce prebrojati broj brojeva u redu (listi) i ispisati koji su to
    public static void ParamsMethod(params int[] Numbers)
    {
        Console.WriteLine("U ovom redu nalazi se {0} brojeva.", Numbers.Length);
        Console.Write("Brojevi su: ");
        foreach (int i in Numbers)
        {
            Console.Write(i + " ");
        }
    }
}
#endregion

#region Studenti klasa
public class Studenti
{
    string _firstName;
    string _lastName;

    public Studenti(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Puno ime studenta je: " + this._firstName + " " + this._lastName);
    }

    ~Studenti()
    {
        // Clean up code
    }
}
#endregion

#region ORS , ORS_R , ORS_I klase
public class ORS
{
    public string name = "Toni";

    public void prosjek()
    {
    }
}

public class ORS_R : ORS
{
    public int a = 10;
}

public class ORS_I : ORS_R
{
    public int b = 20;
}
#endregion

#region ParentClass & ChildClass
public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor called.");
    }

    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    // base() znaci da zelimo pozvati ovaj drugi constructor u klasi ParentClass i u njega proslijediti neki string
    // dok prvi constructor koji ne prima niti jedan parametar nece se pozvati
    public ChildClass() : base("Call second ParenClass constructor.")
    {
        Console.WriteLine("ChildClass Constructor called.");
    }
}

#endregion

#region Circle klasa

public class Circle
{
    // private stavio bezveze
    // private znaci da se ta varijabla, metoda... moze koristiti samo u toj klasi
    public float _PI = 3.14F;
    public int _Radius;

    public Circle(int Radius)
    {
        this._Radius = Radius;
    }

    public float CalculateArea()
    {
        return this._PI * this._Radius * this._Radius;
    }
}

#endregion

#region A & B klase
public class A
{
    // internal znaci da kada napravimo objekt nad klasom B dole da mozemo koristiti ove varijable unutar klase
    // u kojoj se napravi objekt
    protected internal string Fname;
    protected internal string Lname;

    public void PrintFullName()
    {
        Console.WriteLine(Fname + ' ' + Lname + " - Poziv iz A klase");
    }

    public void Func1()
    {
        Console.WriteLine("Test");
    }
}

public class B : A
{
    public void PrintFullName()
    {
        Console.WriteLine(Fname + ' ' + Lname + " - Poziv iz B klase");
    }
}
#endregion

#region MainSection, FirstDivision, SecondDivision, ThirdDivision klase
public class MainSection
{
    public string FirstName = "FirstName";
    public string LastName = "LastName";

    public virtual void FullName()
    {
        Console.WriteLine(FirstName + ' ' + LastName + "- MainSection");
    }
}

public class FirstDivision : MainSection
{
    public override void FullName()
    {
        Console.WriteLine("Promjenjena funkcija (FullName) iz main klase, klasom FirstDivison");
        for (int i = 1; i < 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
public class SecondDivision : MainSection
{
    public override void FullName()
    {
        Console.WriteLine("Promjenjena funkcija (FullName) iz main klase, klasom SecondDivison");
        Console.Write("Dodatna poruka iz klase SecondDivison");
        Console.WriteLine();
    }
}
public class ThirdDivision : MainSection
{
    public override void FullName()
    {
        Console.WriteLine("Promjenjena funkcija (FullName) iz main klase, klasom ThirdDivison");
        for (int i = 6; i < 11; i++)
        {
            Console.Write(i + " ");
        }
    }
}
#endregion

#region class1
public class class1
{
    // private variables
    private int _id;
    private string _Name;

    public void SetId( int Id )
    {
        if ( Id > 0 )
        {
            _id = Id;
        }
        else
        {
            Console.WriteLine("Krivi unos. Id manji ili jednak nuli.");
        }
    }

    public int GetId()
    {
        return _id;
    }

    public void SetName( string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Error. Name cannot be null or empty.");
        }
        
        this._Name = Name;
    }

    public string GetName()
    {
        if ( string.IsNullOrEmpty(this._Name) )
        {
            return "No name";
        }
        else
        {
            return this._Name;
        }
    }
}
#endregion

#region class2
public class class2
{
    private int _id; // read & write property
    private string _Name; // read & write property

    private int _passMark = 3; // we want thas variable to be just read only property

    public int Id
    {
        set
        {
            if (value <= 0) // value je Id odnosno vrijednost koju smo zadali prije pozivanja, u ovom slucaju 101
            {
                throw new Exception("Student Id cannot be negative.");
            }

            this._id = value;
        }
        get
        {
            return this._id;
        }
    }

    public string Name
    {
        set
        {
            if ( string.IsNullOrEmpty( value ) )
            {
                throw new Exception("Name cannot be null or empty.");
            }
            this._Name = value;
        }
        get
        {
            if ( string.IsNullOrEmpty(this._Name) )
            {
                throw new Exception("No name.");
            }
            else
            {
                return this._Name;
            }
        }
    }

    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }
}
#endregion

#region Shop
public class Shop : ICustomer2
{

    public void Print1()
    {
        Console.WriteLine("Interface Print1 method.");
    }

    public void Print2()
    {
        Console.WriteLine("Interface Print2 method.");
    }
}
#endregion

#region class3
public class class3 : I1, I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 interface Method");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface Method");
    }
}
#endregion

#region class4
public class class4 : AbstClass1
{
    public override void Print()
    {
        Console.WriteLine("Print metoda koristena iz apstraktne klase.");
    }

    
}
#endregion

// Multiple class inheritance using interfaces
#region interfaces: I3 & I4   ; classes: A1 , B1 & A1_B1
interface I3
{
    void Method1();
}
interface I4
{
    void Method2();
}
class A1 : I3
{
    public void Method1()
    {
        Console.WriteLine("Class A1 Method1.");
    }
}
class B1 : I4
{
    public void Method2()
    {
        Console.WriteLine("Class B1 - Method2.");
    }
}

class A1_B1 : I3, I4
{
    A1 a1 = new A1();
    B1 b1 = new B1();

    public void Method1()
    {
        a1.Method1();
    }

    public void Method2()
    {
        b1.Method2();
    }
}
#endregion
 
#region class: Employee                                                         #19
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee ( List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach ( Employee employee in employeeList )
        {
            if ( IsEligibleToPromote( employee ) )
            {
                Console.WriteLine(employee.Name + " promoted.");
            }
        }
    }
}
#endregion

#region UserAlreadyLoggedInException
// Exception je vec ugradenja klasa
[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    // ova klasa je jednaka ugradenoj .NET klasi Exception usporedujuci constructore

    public UserAlreadyLoggedInException() : base()
    {

    }

    public UserAlreadyLoggedInException( string message ) : base(message)
    {

    }

    public UserAlreadyLoggedInException( string message, Exception innerException) : base(message, innerException)
    {

    }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}
#endregion

// #21
#region Customer2
public class Customer2
{
    // if gender is 0 = Unknown
    // if gender is 1 = Male
    // if gander is 2 = Female

    public string Name { get; set; }
    public Gender Gender { get; set; }

}
#endregion

// #22
#region Calculator
public class Calculator
{
    // kada dodamo ovaj true kao parametar to znaci da ce se odma prikazati error ukoliko pokusamo koristiti
    // ovu metodu,,, string prije toga je poruka koja ce se ispisati s errorom
    [Obsolete("Use Add(List<int> Numbers) Method", true)]
    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach( int Number in Numbers)
        {
            Sum = Sum + Number;
        }

        return Sum;
    }
}
#endregion

// #23
#region Calculator2
public class Calculator2
{
    public static bool AreEqual<T>(T Value1, T Value2)
    {
        return Value1.Equals(Value2);
    }
}
#endregion

#region Customer3
public class Customer3
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

}
#endregion

#region Cust
public class Cust
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
#endregion

#region Cust1 and SortByName

// sortiranje po placama
public class Cust1 : IComparable<Cust1>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public int CompareTo(Cust1 other){

        return this.Salary.CompareTo( other.Salary );
    }
}

// napravili smo ovu posebnu klasu samo za sortiranje po imenima
public class SortByName : IComparer<Cust1>
{
    public int Compare(Cust1 x, Cust1 y)
    {
        return x.Name.CompareTo(y.Name);
    }
}
#endregion

#region Country
public class Country
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Capital { get; set; }
}
#endregion


#region Cust2
public class Cust2
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string gender { get; set; }
}
#endregion