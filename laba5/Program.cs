internal class Program
{
    private static void Main(string[] args)
    {
        //int n = int.Parse(Console.ReadLine());
        Abiturient[] arra =
        {
new Abiturient("Костенко", "Виктор", "Владиславович", "ул. Бекешская 16", 4, 5, 4, 2, 1),
new Abiturient("Костенко", "Владислав", "Владиславович", "ул. Бекешская 16", 0, 0, 4, 2, 6),
new Abiturient("Медведчук", "Сергей", "Андреевич", "ул. Пушкина 12", 0, 0, 2, 3, 5),
new Abiturient("Икари", "Синдзи", "Геннадьевич", "ул. Фудзимото 1", 0, 0, 5, 1, 1),
new Abiturient(),
new Abiturient("Баринов", "Виктор", "Петрович", "ул. Фритату 2", 15, 10, 1, 0, 1),
new Abiturient("Барискин", "Олег", "Викторович", "ул. Ветеранов 12", 0, 0, 0, 3, 15),
new Abiturient("Верщенко", "Анатолий", "Григорьевич", "ул. Бекешская 23", 0, 0, 4, 2, 6),
};
        Console.WriteLine(arra[6].SUMMOZENOK);
        /*for (int c = 8; c<arra.Length; c++)
        {
            arra[c] = new Abiturient(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        */
        /*for (int i = 0; i < 120000; i++)//вызов создателя экземпляров
            Abiturient.objectGenerator($"Musor {i}", null, null, null, 0, 0, 0, 0, 0);*/
        Abiturient.ProverkaA(arra);
        Abiturient.ProverkaB(arra);
        Abiturient.ProverkaC(arra);


    }
}
/*for (int i = 0; i < 5; i++)
Console.WriteLine(arra[i]);*/