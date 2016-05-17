using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationLab1 {
    class Article
    {
        public Person data; //Данные автора статьи
        public string paper; //Имя статьи
        public double rating; //Рейтинг статьи

        public Article(Person data,string paper,double rating)
        {
            this.data = data;
            this.paper = paper;
            this.rating = rating;
        }

        public Article()
        {
            data = new Person();
            paper = "Имя статьи";
            rating = 0;
        }

        public Person Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public string Paper
        {
            get { return this.paper; }
            set { this.paper = value; }
        }

        public double Rating
        {
            get { return this.rating; }
            set { this.rating = value; }
        }

        public override string ToString()
        {
            return "\n" + "Данные автора статьи: " + this.data + "\n" + "Название статьи: " + this.paper + "\n" + "Рейтинг статьи: " + this.rating + "\n";
        }
    }
}
