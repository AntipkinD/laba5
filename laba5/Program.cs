Abiturient[] arra = new Abiturient[8];
Abiturient Artem = new Abiturient("Костенко", "Виктор", "Владиславович", "ул. Бекешская 16", 4, 5, 4, 2, 1);
Abiturient Vlad = new Abiturient("Костенко", "Владислав", "Владиславович", "ул. Бекешская 16", 0, 0, 4, 2, 6);
Abiturient Sergey = new Abiturient("Медведчук", "Сергей", "Андреевич", "ул. Пушкина 12", 1, 0, 2, 3, 5);
Abiturient Shinji = new Abiturient("Икари", "Синдзи", "Геннадьевич", "ул. Фудзимото 1", 0, 0, 5, 1, 1);
Abiturient NoName = new Abiturient();
Abiturient Victor = new Abiturient("Баринов", "Виктор", "Петрович", "ул. Фритату 2", 15, 10, 1, 0, 1);
Abiturient Kolya = new Abiturient("Барискин", "Олег", "Викторович", "ул. Ветеранов 12", 0, 0, 0, 3, 15);
Abiturient Sasha = new Abiturient("Верщенко", "Анатолий", "Григорьевич", "ул. Бекешская 23", 0, 0, 4, 2, 6);
arra[0] = NoName;
arra[1] = Vlad;
arra[2] = Sergey;
arra[3] = Shinji;
arra[4] = Artem;
arra[5] = Victor;
arra[6] = Kolya;
arra[7] = Sasha;

Abiturient.ProverkaA(arra);
Abiturient.ProverkaB(arra);
ProverkaC(arra);
void ProverkaC(Abiturient[] value)
{
    int m1 = 0;
    int m2 = 0;
    int m3 = 0;
    for (int i = 0; i < value.Length; i++)
    {
        for (int j = 1; i < value.Length; i++)
        {
            
        }
        
    }
}
/*for (int i = 0; i < 5; i++)
Console.WriteLine(arra[i]);*/