using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLab1 {

    class Person {
        //private string name;
        //private string surname;
        //private DateTime BDate;
               
        public Person(string studentname, string studentsurname, System.DateTime studentBDate) {
            this.Name = studentname;
            this.SurName = studentsurname;
            this.bDate = studentBDate;
        }

        public Person() { }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime bDate { get; set; }
        public int inststdBDate// Свойство типа int для получения информации и изменения года рождения в закрытом поле типа DateTime
        {
            get {
                return Convert.ToInt32(bDate);
            }

            set {
                bDate = Convert.ToDateTime(value);
            }
        }

        // перегруженная (override) версия виртуального метода string ToString()
        public override string ToString() {
            return string.Format("{0} {1}\nDate of birth: {2}", Name, SurName, bDate);
        }

        //Виртуальный метод string ToShortString(), который возвращает строку, содержащую только имя и фамилию
        public string ToShortString() {
            return "\n" + "Имя: " + Name + "\n" + "Фамилия: " + SurName;
        }

    }

    class Program {
        static void Main(string[] args) {
        }
    }
}
