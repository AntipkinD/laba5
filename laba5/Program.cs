Abiturient[] arra = new Abiturient[7];

int maxozenki = int.Parse(Console.ReadLine());
Abiturient Artem = new Abiturient("Костенко", "Виктор", "Владиславович", "ул. Бекешская 16", 4, 5, 4, 2, 1);
Abiturient Vlad = new Abiturient("Костенко", "Владислав", "Владиславович", "ул. Бекешская 16", 0, 0, 4, 2, 6);
Abiturient Sergey = new Abiturient("Медведчук", "Сергей", "Андреевич", "ул. Пушкина 12", 0, 0, 2, 3, 5);
Abiturient Shinji = new Abiturient("Икари", "Синдзи", "Геннадьевич", "ул. Фудзимото 1", 0, 0, 5, 1, 1);
Abiturient NoName = new Abiturient();
Abiturient Victor = new Abiturient("Баринов", "Виктор", "Петрович", "ул. Фритату 2", 15, 10, 1, 0, 1);
Abiturient Kolya = new Abiturient("Барискин", "Олег", "Викторович", "ул. Ветеранов 12", 0, 0, 0, 3, 15);
arra[0] = NoName;
arra[1] = Vlad;
arra[2] = Sergey;
arra[3] = Shinji;
arra[4] = Artem;
arra[5] = Victor;
arra[6] = Kolya;

//ProverkaA(arra);
ProverkaB(arra);
ProverkaC(arra);
void ProverkaA(Abiturient[] value)
{
    for(int j = 0; j < arra.Length; j++)
    if (arra[j].oz1 != 0 || arra[j].oz2 != 0)
    {
        Console.WriteLine($"{value[j].asurname} {value[j].bname} {value[j].csecondname}" + " " + $"1: {value[j].oz1}; 2: {value[j].oz2}");
            Console.WriteLine("______________________________________________________________________________________________________________________");
    }
}
void ProverkaB(Abiturient[] value)
{
    for (int j = 0; j < 7; j++)
        if (arra[j].oz1*1 + arra[j].oz2*2 + arra[j].oz3*3 + arra[j].oz4*4 + arra[j].oz5*5 >= maxozenki)
        {
            Console.WriteLine($"{value[j].asurname} {value[j].bname} {value[j].csecondname}, сумма оценок: {arra[j].oz1 * 1 + arra[j].oz2 * 2 + arra[j].oz3 * 3 + arra[j].oz4 * 4 + arra[j].oz5 * 5}");
        }
    Console.WriteLine("______________________________________________________________________________________________________________________");
}
void ProverkaC(Abiturient[] value)
{
    int m1 = 0;
    int m2 = 0;
    for (int j = 0; j < arra.Length; j++)
    {
    if (j == 0)
        {
            if (arra[j].oz1 == 0 & arra[j].oz2 == 0)
            {
                m1 = arra[j].oz1 * 1 + arra[j].oz2 * 2 + arra[j].oz3 * 3 + arra[j].oz4 * 4 + arra[j].oz5 * 5;
            }
            else m1 = 0;
            if (arra[j + 1].oz1 == 0 & arra[j + 1].oz2 == 0)
            {
                m2 = arra[j + 1].oz1 * 1 + arra[j + 1].oz2 * 2 + arra[j + 1].oz3 * 3 + arra[j + 1].oz4 * 4 + arra[j + 1].oz5 * 5;
            }
            else m2 = 0;
            if (m1 > m2)
            {
                Console.WriteLine(arra[j].asurname + " " + arra[j].bname + " " + arra[j].csecondname + " " + m1);
                Console.WriteLine("_________________");
            }
            if (m1 < m2)
                Console.WriteLine(arra[j + 1].asurname + " " + arra[j + 1].bname + " " + arra[j + 1].csecondname + " " + m2);
            if (m1 == m2) //полупроходной балл
            {
                Console.WriteLine("полупроходной балл");
                Console.WriteLine(arra[j].asurname + " " + arra[j].bname + " " + arra[j].csecondname + " " + m1);
                Console.WriteLine(arra[j + 1].asurname + " " + arra[j + 1].bname + " " + arra[j + 1].csecondname + " " + m2);
            }
        }
    if (j >= 1)
        {
            m1 = 0;
            m2 = 0;
            if (arra[j - 1].oz1 == 0 & arra[j - 1].oz2 == 0)
            {
                m1 = arra[j - 1].oz1 * 1 + arra[j - 1].oz2 * 2 + arra[j - 1].oz3 * 3 + arra[j - 1].oz4 * 4 + arra[j - 1].oz5 * 5;
                if (arra[j].oz1 == 0 & arra[j].oz2 == 0)
                {
                    m2 = arra[j].oz1 * 1 + arra[j].oz2 * 2 + arra[j].oz3 * 3 + arra[j].oz4 * 4 + arra[j].oz5 * 5;
                    if (m1 > m2)
                    {
                        Console.WriteLine(arra[j-1].asurname + " " + arra[j-1].bname + " " + arra[j-1].csecondname + " " + m1);
                        Console.WriteLine("_________________");
                    }
                    else if (m1 < m2)
                    {
                        Console.WriteLine(arra[j].asurname + " " + arra[j].bname + " " + arra[j].csecondname + " " + m2);
                    }
                    else if (m1 == m2)
                    {
                        Console.WriteLine("полупроходной балл");
                        Console.WriteLine(arra[j-1].asurname + " " + arra[j-1].bname + " " + arra[j-1].csecondname + " " + m1);
                        Console.WriteLine(arra[j].asurname + " " + arra[j].bname + " " + arra[j].csecondname + " " + m2);
                    }
                }
            }
        }
      }
}

/*for (int i = 0; i < 5; i++)
Console.WriteLine(arra[i]);*/