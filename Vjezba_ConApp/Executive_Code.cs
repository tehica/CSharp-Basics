using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Kako iz klase Complex koristiti get set varijablu
/*
Complex a = new Complex() { Real = 1, Imaginary = 2 };
Complex b = new Complex() { Real = 4, Imaginary = 8 };

Console.WriteLine( a.Real );
Console.WriteLine( a.Imaginary );
Console.ReadLine();
*/
#endregion
#region KLASA Complex
/*

var ClassComplex = new Complex();

ClassComplex.Student();

Console.WriteLine();
Console.WriteLine("Zbroj zadana dva broja je: " +  ClassComplex.SumNums(50, 50) );

Console.WriteLine();
Complex.NumOfYears(21);

// var1 se nalazi na jednoj memorijskoj lokaciji
// pomocu ref funkcije proslijedivanja u metodu numOutput
// stavljamo u istu memorijsku lokaciju varijablu a koja je kao prijemni parametar
// u funkciji i kada tom prijemnom parametru promijenimo vrijednost(broj) promijenit ce
// se i vrijednost varijable var1 u klasi Program 
Console.WriteLine();
Complex.numOutput(ref var1);

// Pozivanje void funkcije iz druge klase
//  ' out int ' koristimo umjesto toga returna i mozemo dodati takvih out vrijednosti kolio zelimo, 
//  ako trebamo vise povratnih rezultata 

// ako imamo 'out int' prije toga moramo kreirati varijable u koje cemo spremiti te rezultate
int Zbroj = 0;
int Razlika = 0;

Console.WriteLine();
ClassComplex.Calculate(100, 50, out Zbroj, out Razlika);

// pozivanje fukcije kojoj cemo kao parametar proslijediti array ( listu brojeva )
Console.WriteLine();
Complex.ParamsMethod( IntArr );
*/
#endregion


// -----------------------------------------------------------
#region CLASS Studenti - CONSTUCTOR IN class
/*
Console.WriteLine();
Studenti Stud = new Studenti("Toni", "Musa");

Stud.PrintFullName();
*/
#endregion

#region CLASS ParenClass & ChildClass - CONSTRUCTORS
/*
// samo s ovom linijom kada pokrenemo program pozvat ce se iz obe klase (ParentClass i ChildClass) constructori
ChildClass ChildC = new ChildClass();
*/
#endregion

#region KLASE ORS , ORS_R i ORS_I - INHERITANCE
/*
// kako napraviti inharitance izmedu dvije klase da su povezane recimo s :
// i onda kada napravimo objekt orsR da mozemo koristiti sve iz dvije klase odjednom
ORS_R orsR = new ORS_R();
int num = orsR.a;
Console.WriteLine( num );

// na ovaj nacin mozemo koristiti sve varijable i metode iz 3 klase odjednom
ORS_I orsI = new ORS_I();
string name = orsI.name;
Console.WriteLine( name );
*/
#endregion

#region KLASE A & B - METHOD HIDING
/*
// odnosi se na to kada imamo funkcije istog imena u nasljedivanju da mozemo pozvati tocno onu koju zelimo
// na nacin dole:

B bClass = new B();
bClass.Fname = "Toni";
bClass.Lname = "Musa";

// kada bi ovako pozvali funkciju PrintFullName koja se isto zove i u klasi A i klasi B pozvat ce se
// funkcija iz klase B, a do fukcije u A klasi necemo moci doci i pozvat ju
bClass.PrintFullName();

// na ovaj nacin to rjesavamo i pozivamo funkciju iz A klase koja se jednako zove kao funkcija u B klasi
( (A)bClass ).PrintFullName();

// mozemo na ovaj nacin pozvati i ostale funkcije koje nemaju isto ime kao neke u drugim klasama
( (A)bClass ).Func1();
*/
#endregion

#region klase(MainSection, FDividion, SDivision, TDivision)- OverRiding virtual methods / Polymorphism
/*
// virtual metode se mogu override-ati drugim metodama iz nasljednih klasa

MainSection[] section = new MainSection[4];

section[0] = new MainSection();
section[1] = new FirstDivision();
section[2] = new SecondDivision();
section[3] = new ThirdDivision();

// za svako nasljedivanje na KLASU MainSection izvrsi metodu FullName i ako postoje metode istog imena
// u nasljednim klasama promijeni funkciju metode
foreach( MainSection s in section )
{
    // u slucaju da je FullName() metoda samo u main klasi onda ce se ta funkcija izvrsiti onoliko
    // puta koliko ima nasljednih funkcija za sebe s potpuno istim kodom, bez promjene 
    s.FullName();

    // ->*
    // u ovom slucaju sam napisao u svakoj nasljednoj klasi metodu istog imena kao i u main klasi
    // metodu: FullName tako da se foreach petljom izvrsava iz svake nasljedne klase kod metoda
    // istog imena, ali razlicitih funkcija
}
*/
#endregion

#region Difference between method overriding and method hiding
// LINK SLIKE: http://prntscr.com/ngtyke
/*

OBJASNJENJE:
slika lijevo... kada napravimo objekt (B) koji se referencira na te dvije klase i pozovemo metodu
Print() izvrsit ce se metoda print iz klase DerivedClass zato sto ta metoda override-a kod iz metode
u klasi BaseClass te ce se izvrsi kod iz metode u klasi DerivedClass

slika desno... kada imamo istu situaciju s objektom (B) i referenciranjem, ali umjesto u klasi
DerivedClass metodu Print() promijenimo iz override u new tada ce se izvrsiti metoda iz klase BaseClass

*/
#endregion

#region how to reference variable at the same memory location as method parameter / METHOD_FUNCTIONS.CS
/*
// ovo znaci da varijabla i ima jednu memorijsku lokaciju i s komandom ref kada tu varijablu prosljedujemo
// u drugu metodu ona dijeli istu memorijsku lokaciju s varijablom koju prima metoda.. te ako promijenimo
// vrijednost tog parametra funkcije na koju je referencirana varijabla koju smo proslijedili
// promijenit ce se i vrijednost varijable koju smo proslijedili kao parametar funkciji/metodi
int i = 0;
Methods.SameMemoryLocation(ref i);

Console.WriteLine(i );
*/
#endregion

#region out parametri u metodama / funkcijama
/*
// kako proslijediti parametre funkciji/metodi , a da nam vrati vise rezultat 
int Total = 0;
int Product = 0;
Methods.Calculate(10, 20, out Total, out Product);

Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
*/
#endregion

#region PARM. ARRAYs | int, string, object arrays
/*

int[] arrNums = { 1, 2, 3, 4, 5 };
Methods.ParamsMethods(arrNums);

Console.WriteLine();


object[] obj1 = { 1, 'a', "Toni" };
Methods.ParamsMethods2(obj1);
            
*/
#endregion

#region Method overloading func_name(int a) and func_name(float a) - same names functions
/*
// Mozemo u jednoj klasi kreirati vise funkcija koje imaju potpuno isto ime, samo se moraju razlikovati
// po barem jednom tipu parametra koji primaju i kada ima damo cijeli broj i float broj kao dole u primjeru
// znati ce se automatski koja se metoda zove po tome kakav tip parametra prosljedujemo

Methods.Add(5);
Methods.Add(5.5F);
*/
#endregion

#region class1: how to set & get PRIVATE varibale from class with calling methods
/*
class1 c1 = new class1();
c1.SetId(1);
Console.WriteLine("Zadali ste id: {0}", c1.GetId() );

c1.SetName("Toni");
Console.WriteLine( "Upisano ime je: {0}", c1.GetName() );
*/
#endregion

//class2: sve se isto odnosi kao i na klasu class1 kako private varijable postaviti i dobiti vrijednost
#region Samo sto je ovo jednostavniji nacin s Read/Write get{} ; set{} propertijima 
/*
class2 c2 = new class2();
// kada proslijedimo ovu vrijednost prvo se izvrsava set{} dio pa onda get{}
c2.Id = 101;

c2.Name = "Toni";

Console.WriteLine("Id: " + c2.Id );
Console.WriteLine("Name: " + c2.Name);
Console.WriteLine("PassMArk: " + c2.PassMark);
*/
#endregion

#region Struct: Customer | koristenje get;set propertija u struct-u sa i bez koristenja constructora
/*

// STRUCTS just like classes can have :
// Private fields, Public Properties, Constructors, Methods

// primjer s koristenjem constructora

Customer Cust2 = new Customer(1, "Toni", "Musa");
Cust2.PrintInfoCustomer();

Console.WriteLine();

// jedan primjer s get ; set propertijima 

Customer Cust = new Customer();
if ( string.IsNullOrEmpty( Cust.Name ) )
{
    Cust.Name = "No name.";
}
if ( string.IsNullOrEmpty( Cust.Surname ) )
{
    Cust.Surname = "No surname.";
}
if ( Cust.ID <= 0 )
{
    Cust.ID = int.MaxValue;
}
            
Cust.PrintInfoCustomer();

*/
#endregion Struct

#region class: shop with inheritable two interfaces
/*
Shop shop = new Shop();

shop.Print1();
shop.Print2();
*/
#endregion

#region class: class3 with two interfaces which have methods with the same names 
/*
class3 c3 = new class3();

((I1) c3).InterfaceMethod();
((I2) c3).InterfaceMethod();
*/
#endregion

#region Abstract class: AbstClass1 and class4    -   ABSTRACT CLASSES & METHODS
/*
// abstract classes
// ako imamo apstraktnu klasu i ako ju zelimo inheritat u obicnu klasu onda moramo sve
// metode unutar nje koristiti u toj klasi, odnosno ispisati sta ce te metode raditi (kod u njima)
// s kljucnom rijeci override nad tom metodom u apstraktnoj klasi

// ako imamo apstraktnu klasu i inheritamo ju na drugu apstraktnu klasu onda ne moramo u njoj ispisati
// sve metode i koristiti ih kao sto bi bio slucaj s obicnom klasom koja nije apstraktna

class4 c4 = new class4();
c4.Print();
*/
#endregion

#region Difference between abstract classes and interfaces      ***
/* 
        1.) Apstraktne klase mogu imati implementaciju (kod) za dvoje metode, a interfejsi to ne mogu
        2.) Interfejsi ne mogu imati fieldove (varijable) za razliku od apstraktnih klasa
        3.) Nad interfejsom mozemo inheritat interfejs, apstraktnu klasu ne
            , a nad apstraktnom klasom mozemo inheritat apstraktnu klasi i interfejs
        4.) Ovo vrijedi i za obicne klase: nad klasom mogu se inheritat vise interfejsa odjednom
            , a nad klasom se moze inheritat samo jena klasa, ne vise njih
        5.) clanovi apstraktne klase (metode, fieldovi, propertiji...) mogu imati access modifiere
            , a clanovi interfejsa ne mogu
*/
#endregion

#region Multiple class inheritance using interfaces
/*
// interfejsi: I3 i I4
// klase:  A1 , B1 i A1_B1

// kada zelimo koristiti metode iz dvije klase u nekoj trecoj klasi to mozemo uciniti na ovaj nacin uz
// pomoc interfejsa
A1_B1 ab1 = new A1_B1();

ab1.Method1();
ab1.Method2();
*/
#endregion

#region DELEGATES basic use
/*
        // DELEGATES
        // Delegate is a type safe function pointer
        // napravimo metodu unutar klase koja je void, int, string... i stavimo kao u ovom primjeru parametar koji prima
        // moze i vise parametara, nebitno
        // onda napravimo delegate koji je isto void i prima string parametar kao metoda koju zelimo koristiti
        // kroz delegate
        // nakon toga napravimo objekt nad delegate-om kao i za klase sto radimo samo kao parametar
        // delegate-u prosljedimo metodu koju cemo koristiti kroz njega
        // te na taj nacin pozivamo metodu kroz delegate kojem prosledimo string neki kao u ovom slucaju 

HelloFunctionDelegate del = new HelloFunctionDelegate( DelegatesMethods.Hello );
del("Name.");
*/
#endregion

// #19
#region DELEGATES usage in c# 
/*
List<Employee> empList = new List<Employee>();

empList.Add(new Employee() { ID = 101, Name = "Toni", Salary = 50000, Experience = 6 });
empList.Add(new Employee() { ID = 102, Name = "Mario", Salary = 40000, Experience = 3 });
empList.Add(new Employee() { ID = 103, Name = "Ivan", Salary = 30000, Experience = 1 });
empList.Add(new Employee() { ID = 104, Name = "Luka", Salary = 20000, Experience = 5 });

IsPromot
able isProm = new IsPromotable( DelegatesMethods.Promote );

Employee.PromoteEmployee(empList, isProm);
*/
#endregion

// #20
#region MULTICAST DELEGATES ; example 1
/*
// Multicast delegate znaci da se jedan delegate odnosi na vise od jedne metode kao u ovom primjeru
SampleDelegate del1, del2, del3, del4;

del1 = new SampleDelegate(DelegatesMethods.SampleMethodOne);
del2 = new SampleDelegate(DelegatesMethods.SampleMethodTwo);
del3 = new SampleDelegate(DelegatesMethods.SampleMethodThree);

del4 = del1 + del2 + del3;  // - del2
del4(); // na ovaj nacin izvrsavamo 2 ili vise metoda odjednom kada ih spremimo u jedan delegate i pozovemo ga
*/
#endregion

#region MULTICAST DELEGATES ; example 2  (better)
/*
SampleDelegate del = new SampleDelegate(DelegatesMethods.SampleMethodOne);
del += DelegatesMethods.SampleMethodTwo;
del += DelegatesMethods.SampleMethodThree;

del();
*/
#endregion

#region MULTICAST DELEGATES with 2 int methods
/*
// ako imamo delegate koji prima vise metoda koje vracaju neke vrijednosti, u ovom slucaju brojeve
// tada ce nam delegate vratiti samo onaj podatak od zadnje metode koju poziva za sobom
// u ovom slucaju izmedu 1 i 2, vratit ce se broj 2

SampleDelegate_2 del = new SampleDelegate_2(DelegatesMethods.Method1);
del += DelegatesMethods.Method2;

int DelegateReturn = del();

Console.WriteLine( DelegateReturn );
*/
#endregion

#region #region MULTICAST DELEGATES with out method parameter
/*
SampleDeletage_3 del = new SampleDeletage_3(DelegatesMethods.Method3);
del += DelegatesMethods.Method4;

int Delegate_parm_outValue = -1;

del(out Delegate_parm_outValue);

Console.WriteLine( Delegate_parm_outValue );
*/
#endregion

#region Exceptions and Inner Exceptions
/*
try
        {
            try
            {
                Console.WriteLine("Enter First Number: ");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number: ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int result = FN / SN;


                Console.WriteLine("Result = {0}", result);
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                // string bez error-a: @"E:\TONI\ENG RIJECI\hrv words.txt"

                string filePath = @"E:\TONI\ENG RIJECI\hr words.txt"; // namjerno sam stavio krivi naziv file-a

                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(Ex.GetType().Name);
                    sw.Write(Ex.ToString());
                    sw.Close();
                    Console.WriteLine("Error. Krivi unos.");
                    Console.WriteLine("Pogledajte error u fileu za logove.");
                }
                else
                {
                    throw new FileNotFoundException(filePath + " is not present.", Ex);
                }

                Console.ReadLine();
            }
        }
        catch (Exception Ex2)
        {
            // Inner exception je prosljedeni exception prije koji se dogodio ovaj , Ex u FileNotFoundException-u

            Console.WriteLine("Current Exception = {0}", Ex2.GetType().Name);


            // ako postoji inner exception ispisi ga...
            if(Ex2.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0}", Ex2.InnerException.GetType().Name);
            }

            Console.ReadLine();
        }
*/
#endregion

#region Custom Exceptions
/*
we used class: UserAlreadyLoggedInException

// kada pokrenemo ovo vidimo na ekranu ispisanu poruku koju nosi exception u klasi koju smo kreirali
// s constructorom koji prima kao parametar 'string'
try
{
    throw new UserAlreadyLoggedInException("User is logged in.");
}
catch(UserAlreadyLoggedInException ex)
{
    Console.WriteLine(ex.Message);
}
*/
#endregion

// #21
#region ENUMS - example how we can use them
/*
// imamo klasu Customer2 koja ima 2 propertija u sebi: Name i Gender
// te na ovaj nacin napravimo objekt nad tom klasom i u isto vrijeme zadamo koliko cemo customera
// "stvoriti" , te nakon toga foreach petljom ispisemo imena i rod kupaca
// uz pomoc metode

// * koristimo iz Classes i Enums
Customer2[] customers = new Customer2[3];

customers[0] = new Customer2
{
    Name = "Mark",
    Gender = Gender.Male
};

customers[1] = new Customer2
{
    Name = "Mary",
    Gender = Gender.Female
};

customers[2] = new Customer2
{
    Name = "Sam",
    Gender = Gender.Unknown
};

foreach (Customer2 customer in customers)
{
    Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, EnumClass.GetGender(customer.Gender));
}
*/
#endregion

#region how to get ENUM Names and Values
/*
 // ispisuje indekse Enuma
int[] values = (int[])Enum.GetValues(typeof(Gender));

foreach(int value in values)
{
    Console.WriteLine( value );
}

// ispisuje vrijednosti Enuma
string[] Names = Enum.GetNames(typeof(Gender));

foreach(string Name in Names)
{
     Console.WriteLine(Name);
}
*/
#endregion

#region Difference between Types and Type Members
/*
// Types are: Classes, Stuctures, Enums, Delegates, Interfaces

Types mogu imati samo 2 access modifier-a , a to su:
- public i internal

Ne mogu biti: private, protected ili protected internal


// Type Members are: fields, properties, constructors, methods


#C access modifiers:
1. Private
2. Protected
3. Internal
4. Protected Internal
5. Public
*/
#endregion

#region Internal and Protected Internal Access Modifiers - opis samo
/*
Internal znaci da taj field ili sto vec oznacimo da je internal mozemo pristupiti samo unutar tog 
projekta u bilo kojoj klasi. I da napravimo instance iz drugog projekta nad tom public 
klasom i dodamo taj projekt u references necemo viditi internal field te ga necemo moci ni pozvati.

Protected Internal je kombinacija internala i protecteda. To znaci da taj field mozemo koristiti 
unutar tog projekta u kojem smo ga definirali i u bilo kojoj nasljedenoj klasi nebitno gdje se ona nalazila, 
moze se nasljedena klasa nalaziti i u drugom projektu, mi cemo i dalje moci pristupiti tom fieldu.
*/
#endregion

#region Access Modifiers for types - opis samo
/*
Za Types (klase, structovi, interfacei, ... ) ako ne stavimo ispred access modifier on je po defaultu internal, 

ako za type membere ne stavimo ispred nikakav access modifier on je po defualtu private.
*/
#endregion

// #22
#region Attributes
/*
Koristimo samo u classes, klasu - Calculator

// An Attribute is a class that inherits from System.Attribute base class.


// na ovaj nacin prosljedujemo listu brojeva koje zelimo i pomocu metode u klasi Calculator
// zbrajamo sve prosljedene brojeve koliko god ih bilo ... ili mozemo bilo sto drugo raditi s njima 

Console.WriteLine(Calculator.Add( new List<int>() { 10, 20, 40 } ));
*/
#endregion

#region Reflections
/*
// uzeo sam za primjer klasu Employee koja ima neke propertye i metode pa sam iz nje ispisivao property names, types
// , method names, types

// Reflections used basically to show object properties and that somebody select them

Type T = typeof(Employee);

Console.WriteLine("Properties in Employee class:");
PropertyInfo[] properties = T.GetProperties();
foreach(PropertyInfo property in properties)
{
    Console.WriteLine("Name: {0} ; Type: {1}", property.Name, property.PropertyType.Name);
}

Console.WriteLine();
Console.WriteLine("Methods in Employee class:");
MethodInfo[] methods = T.GetMethods();
foreach (MethodInfo method in methods)
{
    Console.WriteLine("Name: {0} ; Type: {1}", method.Name, method.ReturnType.Name);
}

*/
#endregion

#region Reflection Example with form
// https://www.youtube.com/watch?v=vHHd3GNOuXU&list=PLAC325451207E3105&index=54
#endregion

// #23
#region Generics
/*
// Generics allow us to design classes and methods decoupled from the data types.

        // mozemo prosljedivati u jednu metodu bilo koje tipove podataka i usporedivati ih bez da u metodi
        // definiramo parametre kao objekte na nacin da koristimo genericse
        // unutar zagrada upisemo tip podatka koji cemo prosljedivati funkciji koja prima parametre i ona
        // automatski konverta parametre u taj tip podatka koji smo zadali
        // sada smo zadali tip podatka <string>

        // klase takoder mogu biti generics

bool Equal = Calculator2.AreEqual<string>("A", "A");

if (Equal) // or (Equal == true)
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not Equal");
}
*/
#endregion

#region working with dictionaries
/*
// how to add few customer object to dictionary and print their id, name, salary separately and trought foreach loop

// Customer3 CLASS          <-----------------------------------------------

        Customer3 customer1 = new Customer3()
        {
            Id = 1,
            Name = "Toni",
            Salary = 10000
        };

        Customer3 customer2 = new Customer3()
        {
            Id = 2,
            Name = "Marko",
            Salary = 20000
        };

        Customer3 customer3 = new Customer3()
        {
            Id = 3,
            Name = "Ivan",
            Salary = 30000
        };

        // adding customer objects to customer dictionary

        Dictionary<int, Customer3> dictCustomers = new Dictionary<int, Customer3>();
        dictCustomers.Add(customer1.Id, customer1);
        dictCustomers.Add(customer2.Id, customer2);
        dictCustomers.Add(customer3.Id, customer3);

       
        Customer3 cust1 = dictCustomers[1];
        Console.WriteLine(cust1.Id + " " + cust1.Name + " " + cust1.Salary);

        foreach(KeyValuePair<int, Customer3> customerKeyValuePair in dictCustomers) // (var customerKeyValuePair in dictCustomers)
        {
            Console.WriteLine("Key = {0}", customerKeyValuePair.Key );
            Customer3 cust = customerKeyValuePair.Value;

            Console.WriteLine("id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            Console.WriteLine(); 
        }

        Console.WriteLine("Keys from dictionary:");
        // how to get all keys from dict
        foreach(var key in dictCustomers.Keys)
            {
                Console.WriteLine( key );
            }
*/
#endregion

#region how to convert array or list into dictionary
/*
// Customer3 class
  
Customer3 customer1 = new Customer3()
{
    Id = 1,
    Name = "Toni",
    Salary = 10000
};

Customer3 customer2 = new Customer3()
{
    Id = 2,
    Name = "Marko",
    Salary = 20000
};

Customer3 customer3 = new Customer3()
{
    Id = 3,
    Name = "Ivan",
    Salary = 30000
};

// Using LINQ extension methods with Dictionary

        
// how to convert array into dictionary
        Customer3[] customers = new Customer3[3];
        customers[0] = customer1;
        customers[1] = customer2;
        customers[2] = customer3;
        
// how to convert LIST into dictionary
        List<Customer3> customerList = new List<Customer3>();
        customerList.Add(customer1);
        customerList.Add(customer2);
        customerList.Add(customer3);

Dictionary<int, Customer3> dict = customers.ToDictionary( cust => cust.Id, cust => cust);
foreach(KeyValuePair<int, Customer3> kvp in dict)
{
    Console.WriteLine("Key = {0}", kvp.Key);
    Customer3 cust1 = kvp.Value;
    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
}
*/
#endregion

#region dictionary few commands: TryGetValue(), Count(), Remove(), Clear()
/*
// CUSTOMER3 CLASS

        Customer3 customer1 = new Customer3()
        {
            Id = 1,
            Name = "Toni",
            Salary = 10000
        };

        Customer3 customer2 = new Customer3()
        {
            Id = 2,
            Name = "Marko",
            Salary = 20000
        };

        Customer3 customer3 = new Customer3()
        {
            Id = 3,
            Name = "Ivan",
            Salary = 30000
        };

        // adding customer objects to customer dictionary

        Dictionary<int, Customer3> dictCustomers = new Dictionary<int, Customer3>();
        dictCustomers.Add(customer1.Id, customer1);
        dictCustomers.Add(customer2.Id, customer2);
        dictCustomers.Add(customer3.Id, customer3);


        // TryGetValue()
        Customer3 cust;
        if (dictCustomers.TryGetValue(5, out cust))
        {
            Console.WriteLine("id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
        }
        else{
            Console.WriteLine("The key is not found.");
        }

        // Count()
        Console.WriteLine("Total items = {0}", dictCustomers.Count() );
        // how to count all objects in dictionary who have salary > 10000
        Console.WriteLine("Total items = {0}", dictCustomers.Count( c => c.Value.Salary > 10000) );

        // Remove()
        // if i execute line below it will remove customer with id 3
        // dictCustomers.Remove(3);

        // Clear
        // if i execute line below it will remove all objects in dictionary
        // dictCustomers.Clear()
*/
#endregion

#region List collections
/*
Cust customer1 = new Cust()
        {
            ID = 1,
            FirstName = "Toni",
            LastName = "Musa"
        };

        Cust customer2 = new Cust()
        {
            ID = 2,
            FirstName = "Ivan",
            LastName = "Ivic"
        };

        List<Cust> customers = new List<Cust>();
        customers.Insert(0, customer2);
        customers.Insert(1, customer1);

        // nalazi li se u listi objekt customer2
        if (customers.Contains(customer2))
        {
            Console.WriteLine("Cust2 object exist in the list");
        }
        else{
            Console.WriteLine("cust2 does not exist in the list");
        }

        // postoji li u listi kupaca objekt koji ima firstName s pocetnim slovom T
        if (customers.Exists(cust => cust.FirstName.StartsWith("T"))){
            Console.WriteLine("Cust2 object exist in the list");
        }
        else{
            Console.WriteLine("cust2 does not exist in the list");
        }

        // nalazi u listi objekt kojem je id jednak 1
        Cust c = customers.Find(cust => cust.ID == 1);
        Console.WriteLine("Fname = {0}, Lname = {1}", c.FirstName, c.LastName);
*/
#endregion

#region Sort a list of complex types and TrueForAll() & TrimExcess() commands
/*
Cust1 customer1 = new Cust1(){
            Id = 100,
            Name = "Mario",
            Salary = 9000
        };

        Cust1 customer2 = new Cust1(){
            Id = 101,
            Name = "Pero",
            Salary = 6000
        };

        Cust1 customer3 = new Cust1(){
            Id = 102,
            Name = "Zlatko",
            Salary = 7000
        };

        List<Cust1> listCustomers = new List<Cust1>(100); // po defaultu u kapacitet liste zadali smo 100
        listCustomers.Add(customer1);
        listCustomers.Add(customer2);
        listCustomers.Add(customer3);

        Console.WriteLine("Before sorting");
        foreach(Cust1 c in listCustomers)
        {
            Console.WriteLine(c.Salary);
        }

        listCustomers.Sort();
        
        Console.WriteLine("After sorting");
        foreach(Cust1 c in listCustomers)
        {
            Console.WriteLine(c.Salary);
        }

        // SORTIRANJE PO IMENIMA
        SortByName sortByName = new SortByName();
        listCustomers.Sort(sortByName);

        Console.WriteLine("Sorting by Name");
        foreach ( Cust1 c in listCustomers )
        {
            Console.WriteLine(c.Name);
        }

        // TrueForAll()
        // u ovom slucaju bi nam vratilo true jer svi imaju placu vecu od 3000, da je jedan imao manju vratilo bi false
        Console.WriteLine( listCustomers.TrueForAll(x => x.Salary > 3000)  );
        
        // TrimExcess()
        // ovom komandom smanjimo listu na tocno onoliko elemenata koliko nam treba, u ovom slucaju sa 100 na 3
        Console.WriteLine("Capacity before trimming: {0}", listCustomers.Capacity);
        listCustomers.TrimExcess();

        Console.WriteLine("Capacity after trimming: {0}", listCustomers.Capacity);
*/
#endregion

#region When to use a dictionary over list
/*
Country country1 = new Country()
        {
            Code = "AUS",
            Name = "AUSTRALIA",
            Capital = "Canberra"
        };

        Country country2 = new Country()
        {
            Code = "IND",
            Name = "INDIA",
            Capital = "New Delhi"
        };

        Country country3 = new Country()
        {
            Code = "USA",
            Name = "UNITED STATES",
            Capital = "Washington D. C."
        };

        Country country4 = new Country()
        {
            Code = "GBR",
            Name = "UNITED KINGDOM",
            Capital = "London"
        };

        Country country5 = new Country()
        {
            Code = "CAN",
            Name = "CANADA",
            Capital = "Ottawa"
        };

        Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
        dictionaryCountries.Add(country1.Code, country1);
        dictionaryCountries.Add(country2.Code, country2);
        dictionaryCountries.Add(country3.Code, country3);
        dictionaryCountries.Add(country4.Code, country4);
        dictionaryCountries.Add(country5.Code, country5);

        string strUserChoice = string.Empty;

        do
        {
            Console.WriteLine("Please enter country code:");
            string strCountryCode = Console.ReadLine().ToUpper();

            Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;

            if (resultCountry == null){

                Console.WriteLine("Country code is not valid");
            }
            else{

                Console.WriteLine("Name= {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
            }

            do
            {
                Console.WriteLine("Do you want to continue - YES or NO? : ");
                strUserChoice = Console.ReadLine().ToUpper();
            }
            while(strUserChoice != "NO" && strUserChoice != "YES");

        }
        while(strUserChoice != "NO");
*/
#endregion

#region Generic Queue collection class
/*

Queue is generic FIFO (first In First Out) collection class that is present
                      in System.Collections.Generic namespace

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
        
        Queue<Cust2> queueCustomer = new Queue<Cust2>();
        queueCustomer.Enqueue(customer1);
        queueCustomer.Enqueue(customer2);
        queueCustomer.Enqueue(customer3);
        queueCustomer.Enqueue(customer4);
        queueCustomer.Enqueue(customer5);

        // TO CHECK if and item exists in the queue use .Contains() method
        if (queueCustomer.Contains(customer1))
        {
            Console.WriteLine("Customer1 exist");
        }
        else{
            Console.WriteLine("Customer1 does not exist");
        }

        // to add items to the end of queue use .Enqueue() method
        // to remove an item that is present at the BEGINNING of the queue, use .Dequeue() method

        // Whats difference between Dequeue() and Peek() methods?
        // Dequeue() methodremoves and return the item at the beginning of the queue, where as
        // Peek() returns the item at the beginning of the queue, without removing it.
*/
#endregion

#region Generic STACK collection class
/*
Stack is generic LIFO (Last In First Out) collection class that is present in System.Collections.Generic namespace

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
        
        // to insert an item at the top of the stack, use Push() method
        // to remove and return the item that is present at the top of stack, use Pop() method
        // to check if an item exists in the stack, use Contains() method

        // Whats differencebetween Pop() and Peek() methods?
        // Pop() method removes and returns the item at the top of stack where as Peek() returns the
        // item at the top of stack without removing it

*/
#endregion