using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace _123
{
    public class Inform //основной класс
    {
        public string name;
        public string author;
        public string keyword;
        public string theme;
        public string path;

        public void exsts() //проверка на существование файла, если его нет, то ничего страшного, создадим
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
        public string get_name()//получение имени
        {
            this.name = System.IO.Path.GetFileNameWithoutExtension(path);
           // Console.WriteLine("Имя файла: " + name);
            return this.name;
        }
        public string get_author()//получение автора
        {
            FileVersionInfo auth = FileVersionInfo.GetVersionInfo(path);
            author = auth.CompanyName;
            return this.author;
        }

        public string get_keyword()//получение ключевый слов
        {
            return this.keyword;
        }
        public string get_theme()//получение темы
        {
            return this.theme;
        }

        public string get_path()//получение пути(здесь не используется так как путь мы получаем вдля разных предметов в разных классах)
        {
            return this.path;
        }
        public virtual void Display()//метод вывода в синглтон
        {
            Console.Write("имя: " + name + "\n" 
            + "путь: " + path + "\n"
            + "автор: " + author + "\n"
            + "ключевые слова: " + keyword + "\n"
            + "тема: " + theme);

        }


    }

    public class Word : Inform //класс наследник для ворда
    {
        public new string get_path()//получаем путь
        {
            path = @"D:\one.docx";
            return this.path;
        }
        public new string get_theme()//указываем темки
        {
            theme = "Редактор текста";
            //Console.WriteLine("Тема: " + theme);
            return this.theme;
        }
        public new string get_keyword()//указываем ключевые словечки
        {
            keyword = "Текст, Редактирование, Ворд";
            //Console.WriteLine("Ключевые слова: " + theme);
            return this.keyword;
        }

        public class PDF : Inform//класс наследник для пдф
        {
            public new string get_path()//получаем путь
            {
                path = @"D:\two.pdf";
                return this.path;
            }
            public new string get_theme()//вписываем темки
            {
                theme = "Электронный Документ";
                return this.theme;
            }
            public new string get_keyword()//вписываем ключевые слова
            {
                keyword = "Текст, Графика, Печать";
                return this.keyword;
            }
        }
        public class Excel : Inform//класс наследник для экселя
        {
            public new string get_path()//получаем путь
            {
                path = @"D:\three.xlsx";
                return this.path;
            }
            public new string get_theme()//пишем темки
            {
                theme = "Таблицы";
                return this.theme;
            }
            public new string get_keyword()//пишем ключевые слова
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
                string choice;//переменная ввода


                while (true)
                {
                    Console.Write("\n____________________________\n" +//меню
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

                    // Проверка на выход
                    if (choice == "0")
                    {
                        Console.Write("\n**ВЫХОД ИЗ ПРИЛОЖЕНИЯ**");
                        break;
                    }
                    switch (choice)//действия по нажатию
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
