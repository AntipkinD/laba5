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
/*public void ProverkaA(Abiturient[] value)
    {
        if (oz1 != 0 || oz2 != 0)
        {
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine($"{value[i].asurname} {value[i].bname} {value[i].csecondname}");
            }
        }
    }*/
}