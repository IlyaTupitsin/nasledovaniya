
using System.Security.Cryptography;

Console.WriteLine("Введите ID работкинка!");
int Id =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите имя работкинка!");
string Name =Console.ReadLine();
Console.WriteLine("Введите номер смены работника!");
int Shift = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите оклад работкника!");
int Work_rate = Convert.ToInt32(Console.ReadLine());
ProductionWorkek productionWorkek = new ProductionWorkek(Name, Id, Shift, Work_rate);
productionWorkek.Print();
ShiftSupervisor shiftSupervisor = new ShiftSupervisor("Igor", 2, 23000, 30000);
shiftSupervisor.Print();
Customer customer = new Customer("Igor", "Gorodishe", "88005553535", 13, true);
customer.Print2();
class Employee
{
    public string _name = "";
    public int _id;

    public Employee(string name, int id)
    {
        Name = name;
        _id = id;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }


    public virtual void Print()
    {
        Console.WriteLine("Id сотрудника: "+Id+", его имя: "+Name);
    }
}

class ProductionWorkek : Employee
{
    int shift;
    int work_rate;
    public int Shift { get; set; }
    public int Work_rate { get; set; }
    public ProductionWorkek(string name,int id, int shift, int work_rate)
        :base(name,id)
    {
        Shift = shift;
        Work_rate = work_rate;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine("смена: "+ Shift + ", ставка: "+ Work_rate);
    }
}

class ShiftSupervisor : Employee
{
    int oklad;
    int premiya;
    public int Oklad { get; set; }
    public int Premiya { get; set; }
    public ShiftSupervisor(string name, int id, int oklad, int premiya)
        : base(name, id)
    {
        Oklad = oklad;
        Premiya = premiya;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine("Оклад: " + Oklad + ", Премия: " + Premiya);
    }
}

class Person
{   string name;
    string adres;
    string telefon;
    public string Name { get { return name; } set { name = value; } }   
    public string Adres { get { return adres; } set {  adres = value; } }
    public string Telefon { get {  return telefon; } set { telefon = value; } }
    public Person(string name, string adres, string telefon)
    {
        Name = name;
        Adres = adres;
        Telefon = telefon;
    }
    public virtual void Print2()
    { Console.WriteLine("Имя: "+Name + " адрес: " + Adres + " телефон: " + Telefon); }

}
class Customer : Person
{
    int nomer;
    bool rass;
    public int Nomer { get { return nomer; } set {  nomer = value; } }
    bool Rass { get { return rass; } set {  rass = value; } }
    public Customer(string name, string adres ,string telefon, int nomer, bool rass)
        :base(name,adres,telefon)
    {
        Nomer = nomer;
        Rass = rass;
    }
    public override void Print2()
    { Console.WriteLine("Имя: " + Name + " номер клиента: " + Nomer + " телефон: " + Telefon +" адрес: "+Adres+" желание получать рассылку: "+Rass); }

}

