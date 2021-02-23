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
           // Console.WriteLine("Имя файла: " + name);
            return this.name;
        }
        public string get_author()
        {
            FileVersionInfo auth = FileVersionInfo.GetVersionInfo(path);
            author = auth.CompanyName;
            return this.author;
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
        public virtual void Display()
        {
            Console.Write("имя: " + name + "\n" 
            + "путь: " + path + "\n"
            + "автор: " + author + "\n"
            + "ключевые слова: " + keyword + "\n"
            + "тема: " + theme);

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
            //Console.WriteLine("Тема: " + theme);
            return this.theme;
        }
        public new string get_keyword()
        {
            keyword = "Текст, Редактирование, Ворд";
            //Console.WriteLine("Ключевые слова: " + theme);
            return this.keyword;
        }
        public new virtual void Display()
        {
            Console.WriteLine("Name:" + name);

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
                return this.theme;
            }
            public new string get_keyword()
            {
                keyword = "Текст, Графика, Печать";
                return this.keyword;
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
                return this.theme;
            }
            public new string get_keyword()
            {
                keyword = "Графики, Расписание, Таблицы";
                return this.keyword;
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
                return this.theme;
            }
            public new string get_keyword()
            {
                keyword = "Текст, Заметки, Записи";
                return this.keyword;
            }
        }
        public class Html : Inform
        {
            public new string get_path()
            {
                path = @"D:\five.html";
                return this.path;
            }
            public new string get_theme()
            {
                theme = "Html";
                return this.theme;
            }
            public new string get_keyword()
            {
                keyword = "Веб страница, Сайт";
                return this.keyword;
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                string choice;


                while (true)
                {
                    Console.Write("\n____________________________\n" +
                        "Введите номер документа, информацию которого вы хотите вывести? \n " +
                        "0) *ВЫХОД ИЗ ПРОГРАММЫ* \n " +
                        "1) MS Word \n " +
                        "2) PDF \n " +
                        "3) MS Excel \n " +
                        "4) TXT \n " +
                        "5) HTML \n" +
                        "Ввод: ");
                    choice = Console.ReadLine();
                    Console.Clear();

                    // Проверка на команду выхода из приложения
                    if (choice == "0")
                    {
                        Console.Write("\n**ВЫХОД ИЗ ПРИЛОЖЕНИЯ**");
                        break;
                    }
                    switch (choice)
                    {
                        case "1":
                            Word One = new Word();
                            One.get_path();
                            One.exsts();
                            One.get_name();
                            One.get_author();
                            One.get_theme();
                            One.get_keyword();
                            Singleton.Instance.Output(One);
                            break;
                        case "2":
                            PDF two = new PDF();
                            two.get_path();
                            two.exsts();
                            two.get_name();
                            two.get_author();
                            two.get_theme();
                            two.get_keyword();
                            Singleton.Instance.Output(two);
                            break;
                        case "3":
                            Excel three = new Excel();
                            three.get_path();
                            three.exsts();
                            three.get_name();
                            three.get_author();
                            three.get_theme();
                            three.get_keyword();
                            Singleton.Instance.Output(three);
                            break;
                        case "4":
                            Txt four = new Txt();
                            four.get_path();
                            four.exsts();
                            four.get_name();
                            four.get_author();
                            four.get_theme();
                            four.get_keyword();
                            Singleton.Instance.Output(four);
                            break;
                        case "5":
                            Html five = new Html();
                            five.get_path();
                            five.exsts();
                            five.get_name();
                            five.get_author();
                            five.get_theme();
                            five.get_keyword();
                            Singleton.Instance.Output(five);
                            break;
                        default:
                            Console.Write("\n **ERROR: Введён неправильный номер документа!! Попробуйте ещё раз!! Введите \"0\" для выхода из приложения** \n");
                            break;
                    }
                }

            }

        }
        public class Singleton
        {
            public static Singleton Instance
            {
                get
                {
                    if (_instance == null) _instance = new Singleton();
                    return _instance;
                }
            }
            public void Output(Inform doc)
            {
                doc.Display();
            }
            private Singleton() { }
            private static Singleton _instance;

        }

    }
}
