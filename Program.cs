using System;
using System.IO;

namespace _123
{
    public class Inform
    {
        public string name;
        public string author;
        public string keyword;
        public string theme;
        public string path;

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

        public string get_path()
        {
            return this.path;
        }
        public void set_path(string new_path)
        {
            this.path = new_path;
        }
    }

    public class Word : Inform
    {
        public new string get_path()
        {
            path = @"D:\one.docx";
            return this.path;
        }
        public void exsts()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Файл Существует");
            }
            else
            {
                File.Create(path);
            }
        }
        public new string get_name()
        {
            this.name = System.IO.Path.GetFileNameWithoutExtension(path);
            Console.WriteLine("Имя файла: "+name);
            return this.name;
        }

      
    }

    class Program
    {
        static void Main(string[] args)
        {
            Word One = new Word();
            One.get_path();
            One.exsts();
            Console.WriteLine("Путь файла: "+One.path);
            One.get_name();

        }
    }


}
