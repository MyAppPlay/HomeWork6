using System;
using System.Collections;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int bakalavr = 0;
        int magistr = 0;
        // Создадим необобщенный список
        ArrayList list = new ArrayList();
        // Запомним время в начале обработки данных
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("student.csv"); ; ;
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);



                list.Add(s[1] + " " + s[0]);// Добавляем склееные имя и фамилию
                if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
            }
            catch
            {
            }
        }
        sr.Close();
        list.Sort();
        Console.WriteLine("Всего студентов:{0}", list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        foreach (var v in list) Console.WriteLine(v);
        // Вычислим время обработки данных
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }

}
//Дороничева;Дарья;1 курс;18 лет;
//Карасева;Анна;2 курс;19 лет;
//Ковыгина;Карина;3 курс;20 лет;
//Кушаева;Ксения;4 курс;21год;
//Смурова;Валерия;5курс;24 года;
//Якушкина;Карина;6 курс;19 лет;
//Акоповa;Лилия;1 курс;22 года;
//Багиров;Эльчин;2 курс;23 года;
//Блавацкий;Андрей;3 курс;24 года;
//Бондаренко;Валерия;4 курс;25 лет;
//Котельникова;Анастасия;5 курс;23 года;
//Мусаллямова;Любовь;6 курс;25 лет;
//Санюк;Анна;1 курс;18 лет;
//Травкина;Юлия;2 курс;20 лет;
//Тырыкина;Марина;3 курс; 21 год;
//Швоева;Ксения;4 курс; 22 года;
//Юхалова;Елизавета;5 курс; 22 года;