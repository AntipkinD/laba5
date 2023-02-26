using System.Security.Cryptography.X509Certificates;
using System.Linq;
internal class Abiturient
{
    string asurname, bname, csecondname, eadres;
    int oz1, oz2, oz3, oz4, oz5;
    int summozenok;
    internal Abiturient() //конструктор по умолчанию
    {
        this.asurname = "unknown";
        this.bname = "unknown";
        this.csecondname = "unkniwn";
        this.eadres = "unknown";
        this.oz1 = 0;
        this.oz2 = 0;
        this.oz3 = 0;
        this.oz4 = 0;
        this.oz5 = 0;
        this.summozenok = this.oz1 * 1 + this.oz2 * 2 + this.oz3 * 3 + this.oz4 * 4 + this.oz5 * 5;
    }
    internal Abiturient(string surname, string name, string secondname, string adres, int oz1, int oz2, int oz3, int oz4, int oz5)
    {
        ASURNAME = surname;
        BNAME = name;
        csecondname = surname;
        EADRES = adres;
        OZ1 = oz1;
        OZ2 = oz2;
        OZ3 = oz3;
        OZ4 = oz4;
        OZ5 = oz5;
        SUMMOZENOK = summozenok;
    }
    public string ASURNAME
    {
        get { return asurname; }
        set { asurname = value; }
    }
    public string BNAME
    {
        get { return bname; }
        set { bname = value; }
    }
    public string CSECONDNAME
    {
        get { return csecondname; }
        set { csecondname = value; }
    }
    public string EADRES
    {
        get { return eadres; }
        set { eadres = value; }
    }
    public int OZ1
    {
        get { return oz1; }
        set { oz1 = value; }
    }
    public int OZ2
    {
        get { return oz2; }
        set { oz2 = value; }
    }
    public int OZ3
    {
        get { return oz3; }
        set { oz3 = value; }
    }
    public int OZ4
    {
        get { return oz4; }
        set { oz4 = value; }
    }
    public int OZ5
    {
        get { return oz5; }
        set { oz5 = value; }
    }
    public int SUMMOZENOK
    {
        get { return summozenok; }
        set { summozenok = OZ1*1 + OZ2*2 + OZ3*3 + OZ4*4 + OZ5*5; }
    }

    /*~Abiturient() //деструктор
        {   
            Console.WriteLine($"Объект {this.asurname} уничтожен");
        }
    internal static void objectGenerator(string surname, string name, string secondname, string adres, int oz1, int oz2, int oz3, int oz4, int oz5) //создатель объектов
        {
            Abiturient abi = new Abiturient(surname, name, secondname, adres, oz1, oz2, oz3, oz4, oz5);
        }*/
    internal static void ProverkaA(Abiturient[] value)
    {
        Console.WriteLine("Неудовлетворительные оценки имеют следующие студенты");
        for (int j = 0; j < value.Length; j++)
            if (value[j].OZ1 != 0 || value[j].OZ2 != 0)
            {
                Console.WriteLine($"{value[j].ASURNAME} {value[j].BNAME} {value[j].CSECONDNAME}" + " " + $"1: {value[j].OZ1}; 2: {value[j].OZ2}");
            }
        Console.WriteLine("______________________________________________________________________________________________________________________");
    }
    internal static void ProverkaB(Abiturient[] value)
    {
        Console.WriteLine("Укажите сумму баллов ");
        int maxozenki = int.Parse(Console.ReadLine());
        Console.WriteLine($"Студенты, сумма баллов которых не ниже {maxozenki}:");
        for (int j = 0; j < value.Length; j++)
            if (value[j].summozenok >= maxozenki)
            {
                Console.WriteLine($"{value[j].asurname} {value[j].bname} {value[j].csecondname}, сумма оценок: {value[j].summozenok}");
            }
        Console.WriteLine("______________________________________________________________________________________________________________________");
    }
    internal static void ProverkaC(Abiturient[] value)
    {
        Console.WriteLine("Абитуриенты, упорядоченные по убыванию суммы оценок:");
        var provc = value.OrderByDescending(ob => ob.summozenok).ToArray();
        Array.ForEach(provc, Console.WriteLine);
        Console.WriteLine("______________________________________________________________________________________________________________________");
    }
    public override string ToString()
    {
        return $"{asurname} {bname} {csecondname} с суммой оценок {summozenok}";
    }
}