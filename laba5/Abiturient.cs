public class Abiturient
{
    public string asurname, bname, csecondname, eadres;
    public int oz1, oz2, oz3, oz4, oz5;
public Abiturient() 
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
        }
public Abiturient(string surname, string name, string secondname, string adres, int oz1, int oz2, int oz3, int oz4, int oz5)
    {
        this.asurname = surname;
        this.bname = name;
        this.csecondname = secondname;
        this.eadres = adres;
        this.oz1 = oz1;
        this.oz2 = oz2;
        this.oz3 = oz3;
        this.oz4 = oz4;
        this.oz5 = oz5;
    }
public static void ProverkaA(Abiturient[] value)
    {
        Console.WriteLine("Неудовлетворительные оценки имеют следующие студенты");
        for (int j = 0; j < value.Length; j++)
            if (value[j].oz1 != 0 || value[j].oz2 != 0)
            {
                Console.WriteLine($"{value[j].asurname} {value[j].bname} {value[j].csecondname}" + " " + $"1: {value[j].oz1}; 2: {value[j].oz2}");
            }
        Console.WriteLine("______________________________________________________________________________________________________________________");
    }
public static void ProverkaB(Abiturient[] value)
    {
        Console.WriteLine("Укажите сумму баллов ");
        int maxozenki = int.Parse(Console.ReadLine());
        Console.WriteLine($"Студенты, сумма баллов которых не ниже {maxozenki}:");
        for (int j = 0; j < value.Length; j++)
            if (value[j].oz1 * 1 + value[j].oz2 * 2 + value[j].oz3 * 3 + value[j].oz4 * 4 + value[j].oz5 * 5 >= maxozenki)
            {
                Console.WriteLine($"{value[j].asurname} {value[j].bname} {value[j].csecondname}, сумма оценок: {value[j].oz1 * 1 + value[j].oz2 * 2 + value[j].oz3 * 3 + value[j].oz4 * 4 + value[j].oz5 * 5}");
            }
        Console.WriteLine("______________________________________________________________________________________________________________________");
    }
}