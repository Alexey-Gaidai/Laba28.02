using System;
using System.IO;

namespace _123
{
    public class Inform
    {
        string name;
        string author;
        string keyword;
        string theme;
        string way;

        public string get_name()
        {
            return this.name;
        }
        public void set_name(string new_name)
        {
            this.name = new_name;
        }

        public string get_author()
        {
            return this.author;
        }
        public void set_author(string new_author)
        {
            this.author = new_author;
        }

        public string get_keyword()
        {
            return this.keyword;
        }
        public void set_keyword(string new_keyword)
        {
            this.keyword = new_keyword;
        }

        public string get_theme()
        {
            return this.theme;
        }
        public void set_theme(string new_theme)
        {
            this.theme = new_theme;
        }

        public string get_way()
        {
            return this.way;
        }
        public void set_path(string new_way)
        {
            this.way = new_way;
        }
    }

    public class Word : Inform
    {

    }

    public class Pdf : Inform
    {

    }

    public class Excel : Inform
    {

    }

    public class Txt : Inform
    {

    }

    public class Html : Inform
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Inform x = new Inform();
            x.set_name("50 shades of icecream");
            x.set_keyword("new; fresh; bestseller");
            Console.WriteLine($"name - {x.get_name()};\nkeywords - {x.get_keyword()}");
        }
    }


}
