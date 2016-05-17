using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationLab1 {
    class Person
    {
        private string name; //Имя
        private string surname; //Фамилия
        private DateTime date; //Дата рождения

        public Person(string name, string surname, DateTime date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
        }

        public Person()
        {
            this.name = "Имя";
            this.surname = "Фамилия";
            this.date = new DateTime(1970,9,23);
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Surname
        {
            set { this.surname = value; }
            get { return this.surname; }
        }

        public DateTime Date
        {
            set { this.date = value; }
            get { return this.date; }
        }

        public int DateYear
        {
            get { return this.date.Year; }
            set { this.date = new DateTime(value, date.Month, date.Day); }
        }

        public virtual string ToShortString()
        {
            return "Имя: " + this.name + "\n" + "Фамилия: " + this.surname + "\n";
        }

        public override string ToString()
        {
            return "\n" + "Имя: " + this.name + "\n" + "Фамилия: " + this.surname + "\n" + "Дата рождения: " + this.date + "\n";
        }   
    }
}
