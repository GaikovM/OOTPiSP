using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationLab1 {
    class Magazine
    {
        private string journal; //Название журнала
        private Frequency periodicity; //Периодичность выхода журнала
        private DateTime realese; //Дата выхода журнала
        private int number; //Тираж журнала
        private Article[] list = new Article[0]; //Список(количество) статей в журнале

        public Magazine(string journal,Frequency periodicity,DateTime realese,int number)
        {
            this.journal = journal;
            this.periodicity = periodicity;
            this.realese = realese;
            this.number = number;
        }

        public Magazine()
        {
            this.journal = "Название журнала";
            this.periodicity = Frequency.Weekly;
            this.realese = new System.DateTime(2011, 9, 1);
            this.number = 20000;
        }

        public string Journal
        {
            get { return this.journal; }
            set { this.journal = value; }
        }

        public Frequency Periodicity
        {
            get { return this.periodicity; }
            set { this.periodicity = value; }
        }

        public DateTime Realese
        {
            get { return this.realese; }
            set { this.realese = value; }
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public Article[] List
        {
            get { return this.list; }
            set { this.list = value; }
        }

        public double AvirageRating
        {
            get
            {
                double sum = 0;
                if (this.list.Length > 0)
                {
                    for (int i = 0; i < this.list.Length; i++)
                        sum += this.list[i].rating;
                    sum /= this.list.Length;
                }
                return sum; 
            }
        }

        public bool this[Frequency index]
        {
            get
            {
                if (index == this.periodicity) return true;
                else return false;
            }
        }

        public void AddArticles(params Article[] elements)
        {
                for (int i = 0; i < elements.Length; i++)
                {
                    Array.Resize(ref this.list, this.list.Length + 1);
                    this.list[i] = elements[i];
                }
        }

        public override string ToString()
        {
            string tpd = "";
            tpd+= "Имя журнала: " + this.journal + "\n" + "Периодичность выхода журнала: " + this.periodicity + "\n" + "Дата выхода журнала: " + this.realese + "\n" + "Тираж журнала: " + this.number + " копий" + "\n";

            for (int i = 0; i < this.list.Length; i++)
            {
                tpd += this.list[i];
            }
            return tpd;  
        }

        public virtual string ToShortString()
        {
            return "Имя журнала: " + this.journal + "\n" + "Периодичность выхода журнала: " + this.periodicity + "\n" + "Дата выхода журнала: " + this.realese + "\n" + "Тираж журнала: " + this.number + " копий" + "\n" + "Средний рейтинг статей: " + this.AvirageRating + "\n";
        }
    }
}
