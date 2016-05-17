using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLab1 {

    class Person {
        private string name;
        private string surname;
        private DateTime BDate;
               
        public Person(string studentname, string studentsurname, System.DateTime studentBDate) {
            this.name = studentname;
            this.surname = studentsurname;
            this.BDate = studentBDate;
        }

        public Person() { }
        private string stdname;// Свойство типа string для доступа к полю с именем
        public string Name {
            get {
                return name;
            }


        }
        private string stdtsecondname;// Свойство типа string для доступа к полю с фамилией
        public string Surname {
            get {
                return surname;
            }

        }
        DateTime stdBDate// Свойство типа DateTime для доступа к полю с датой рождения
        {
            get {
                return BDate;
            }
        }

        public int inststdBDate// Свойство типа int для получения информации и изменения года рождения в закрытом поле типа DateTime
        {
            get {
                return Convert.ToInt32(BDate);
            }

            set {
                BDate = Convert.ToDateTime(value);
            }
        }

        // перегруженная (override) версия виртуального метода string ToString()
        public override string ToString() {
            return string.Format("{0} {1}\nDate of birth: {2}", Name, surname, BDate);
        }

        //Виртуальный метод string ToShortString(), который возвращает строку, содержащую только имя и фамилию
        public string ToShortString() {
            return "\n" + "Имя: " + Name + "\n" + "Фамилия: " + surname;
        }


    }
    enum Frequency { Weekly, Monthly, Yearly }

    class Article {

      public Person AboutAuthor { get; set; }
      public string Title { get; set; }
      public double Top { get; set; }

        //Конструктор с параметрами типа Person, string, double для инициализации всех свойств класса
        public Article(Person writtername, string header, double rang) {
            this.AboutAuthor = writtername;
            this.Title = header;
            this.Top = rang;
        }

        //Конструктор без параметров
        public Article() {}

        // перегруженная (override) версия виртуального метода string ToString()
        public override string ToString() {
            return string.Format("{0} {1}\n: {2}", AboutAuthor, Title, Top);
        }
    }

    //Опеделить класс Magazine, который имеет пять закрытых полей
    class Magazine {

    private string title; //закрытое поле типа string c названием журнала
    private Frequency periodicity; //закрытое поле типа Frequency с информацией о периодичности выхода журнала
    private DateTime RDate; //закрытое поле типа DateTime c датой выхода журнала
    private int circulation; //закрытое поле типа int с тиражом журнала
    private Article[] list; //закрытое поле типа Article [] со списком статей в журнале

    //конструктор с параметрами типа string, Frequency, DateTime, int для инициализации соответствующих полей класса

    private Magazine(string header, Frequency rhythm, DateTime publicationdate, int quantity) {
        this.title = header;
        this.periodicity = rhythm;
        this.RDate = publicationdate;
        this.circulation = quantity;
    }

    //конструктор без параметров, инициализирующий поля класса значениями по умолчанию
    private Magazine()
            : this("Leonardo da Vinci", new Frequency(), new DateTime(), 10000) 
        { }

    //В классе Magazine определить свойства c методами get и set:
    private string header;// Свойство типа string для доступа к полю с названием журнала
    public string Name {
        get {
            return title;
        }


    }
    private Frequency rhythm;// Свойство типа string для доступа к полю с информацией о периодичности выхода журнала
    public Frequency Periodicity {
        get {
            return periodicity;
        }

    }
    DateTime publicationdate// Свойство типа DateTime для доступа к полю с датой выхода журнала
    {
        get {
            return RDate;
        }
    }

    int quantity// Свойство типа int доступа к полю с тиражом журнала
    {
        get {
            return circulation;
        }
    }

    // Cвойство типа Article*+ для доступа к полю со списком статей
    public Article[] Name {
        get {
            return list;
        }
    }

    //Cвойство типа double ( только с методом get), в котором вычисляется среднее значение рейтинга в списке статей
    public double Average<Article[]>(
                        this IEnumerable<Article[]> rang,
                        Func<Article[], long> selector) {
        get
            {
            return Top;
        }
    }

}

class Program {
        static void Main(string[] args) {
        }
    }
}
