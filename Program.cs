using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace _123
{
    public class Inform
    {
        public string name;
        public string author;
        public string keyword;
        public string theme;
        public string path;

        public void exsts()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Файл Существует");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("Файл был создан");
            }
        }
        public string get_name()
        {
            this.name = System.IO.Path.GetFileNameWithoutExtension(path);
            Console.WriteLine("Имя файла: " + name);
            return this.name;
        }
        public void get_author()
        {
            FileVersionInfo auth = FileVersionInfo.GetVersionInfo(path);
            Console.WriteLine("Имя компании: " + auth.CompanyName);
        }

        public string get_keyword()
        {
            return this.keyword;
        }
        public string get_theme()
        {

            return this.theme;
        }
       
        public string get_path()
        {
            return this.path;
        }

    }

    public class Word : Inform
    {
        public new string get_path()
        {
            path = @"D:\one.docx";
            return this.path;
        }
        public new string get_theme()
        {
            theme = "Редактор текста";
            Console.WriteLine("Тема: " + theme);
            return this.theme; 
        }
        public new string get_keyword()
        {
            theme = "Текст, Редактирование, Ворд";
            Console.WriteLine("Ключевые слова: " + theme);
            return this.theme;
        }

        public class PDF : Inform
        {
            public new string get_path()
            {
                path = @"D:\two.pdf";
                return this.path;
            }
            public new string get_theme()
            {
                theme = "Электронный Документ";
                Console.WriteLine("Тема: " + theme);
                return this.theme;
            }
            public new string get_keyword()
            {
                theme = "Текст, Графика, Печать";
                Console.WriteLine("Ключевые слова: " + theme);
                return this.theme;
            }
        }
        public class Excel : Inform
        {
            public new string get_path()
            {
                path = @"D:\three.xlsx";
                return this.path;
            }
            public new string get_theme()
            {
                theme = "Таблицы";
                Console.WriteLine("Тема: " + theme);
                return this.theme;
            }
            public new string get_keyword()
            {
                theme = "Графики, Расписание, Таблицы";
                Console.WriteLine("Ключевые слова: " + theme);
                return this.theme;
            }
        }
        public class Txt : Inform
        {
            public new string get_path()
            {
                path = @"D:\four.txt";
                return this.path;
            }
            public new string get_theme()
            {
                theme = "Блокнот";
                Console.WriteLine("Тема: " + theme);
                return this.theme;
            }
            public new string get_keyword()
            {
                theme = "Текст, Заметки, Записи";
                Console.WriteLine("Ключевые слова: " + theme);
                return this.theme;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Word_();
                Console.WriteLine("_____________________");
                Pdf_();
                Console.WriteLine("_____________________");
                Excel_();
                Console.WriteLine("_____________________");
                Txt_();
            }
            static void Word_()
            {
                Word One = new Word();
                One.get_path();
                One.exsts();
                Console.WriteLine("Путь файла: " + One.path);
                One.get_name();
                One.get_author();
                One.get_theme();
                One.get_keyword();
            }
            static void Pdf_()
            {
                PDF two = new PDF();
                two.get_path();
                two.exsts();
                Console.WriteLine("Путь файла: " + two.path);
                two.get_name();
                two.get_author();
                two.get_theme();
                two.get_keyword();
            }
            static void Excel_()
            {
                Excel three = new Excel();
                three.get_path();
                three.exsts();
                Console.WriteLine("Путь файла: " + three.path);
                three.get_name();
                three.get_author();
                three.get_theme();
                three.get_keyword();
            }
            static void Txt_()
            {
                Txt four = new Txt();
                four.get_path();
                four.exsts();
                Console.WriteLine("Путь файла: " + four.path);
                four.get_name();
                four.get_author();
                four.get_theme();
                four.get_keyword();
            }

        }
        
    }




}
