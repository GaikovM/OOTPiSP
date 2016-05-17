using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLab1 {
    enum Frequency { Weekly, Monthly, Yearly }

    class Program {
        static void Main(string[] args) {
            Person pers = new Person("Григорий", "Великий", new DateTime(1970, 7, 13));
            Person pers2 = new Person("Владислав", "Горянский", new DateTime(1979, 4, 11));
            Person pers3 = new Person("Сергей", "Нефредов", new DateTime(1968, 6, 19));

            Magazine magaz1 = new Magazine("Русская Правда1", Frequency.Weekly, new DateTime(2011, 10, 1), 15000);
            Article[] elements = { new Article(pers, "Криминальный мир", 8.0), new Article(pers2, "Власть в теперешние дни", 8.5), new Article(pers3, "Иллюзия свободы", 9.0) };
            magaz1.AddArticles(elements);

            Console.WriteLine("С помощью метода magaz1.ToShortString() : " + "\n" + magaz1.ToShortString());

            Console.WriteLine(magaz1[Frequency.Weekly]);
            Console.WriteLine(magaz1[Frequency.Monthly]);
            Console.WriteLine(magaz1[Frequency.Yearly]);
            Console.WriteLine(Frequency.Weekly + "->" + (int) Frequency.Weekly);
            Console.WriteLine(Frequency.Monthly + "->" + (int) Frequency.Monthly);
            Console.WriteLine(Frequency.Yearly + "->" + (int) Frequency.Yearly);

            Console.WriteLine("С помощью метода magaz1.ToString() : " + "\n" + magaz1.ToString());

            Console.ReadLine();
        }
    }
}
