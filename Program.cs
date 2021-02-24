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

        public void Exists() //проверка на существование файла, если его нет, то ничего страшного, создадим
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
        public string Name()//получение имени
        {
            this.name = System.IO.Path.GetFileNameWithoutExtension(path);
            // Console.WriteLine("Имя файла: " + name);
            return this.name;
        }
        public string Author()//получение автора
        {
            FileVersionInfo auth = FileVersionInfo.GetVersionInfo(path);
            author = auth.CompanyName;
            return this.author;
        }

        public string Keywords()//получение ключевый слов
        {
            return this.keyword;
        }
        public string Theme()//получение темы
        {
            return this.theme;
        }

        public string Path()//получение пути(здесь не используется так как путь мы получаем вдля разных предметов в разных классах)
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
        public new string Path()//получаем путь
        {
            path = @"D:\one.docx";
            return this.path;
        }
        public new string Theme()//указываем темки
        {
            theme = "Редактор текста";
            //Console.WriteLine("Тема: " + theme);
            return this.theme;
        }
        public new string Keywords()//указываем ключевые словечки
        {
            keyword = "Текст, Редактирование, Ворд";
            //Console.WriteLine("Ключевые слова: " + theme);
            return this.keyword;
        }
    }

        public class PDF : Inform//класс наследник для пдф
        {
            public new string Path()//получаем путь
            {
                path = @"D:\two.pdf";
                return this.path;
            }
            public new string Theme()//вписываем темки
            {
                theme = "Электронный Документ";
                return this.theme;
            }
            public new string Keywords()//вписываем ключевые слова
            {
                keyword = "Текст, Графика, Печать";
                return this.keyword;
            }
        }
   
    public class Excel : Inform//класс наследник для экселя
    {
        public new string Path()//получаем путь
        {
            path = @"D:\three.xlsx";
            return this.path;
        }
        public new string Theme()//пишем темки
        {
            theme = "Таблицы";
            return this.theme;
        }
        public new string Keywords()//пишем ключевые слова
        {
            keyword = "Графики, Расписание, Таблицы";
            return this.keyword;
        }
    }
    public class Txt : Inform
    {
        public new string Path()
        {
            path = @"D:\four.txt";
            return this.path;
        }
        public new string Theme()
        {
            theme = "Блокнот";
            return this.theme;
        }
        public new string Keywords()
        {
            keyword = "Текст, Заметки, Записи";
            return this.keyword;
        }
    }

        public class Html : Inform
        {
            public new string Path()
            {
                path = @"D:\five.html";
                return this.path;
            }
            public new string Theme()
            {
                theme = "Html";
                return this.theme;
            }
            public new string Keywords()
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
                    Console.WriteLine("\n=======================\n" +//меню
                        "Меню: \n " +
                        "1 - Word \n " +
                        "2 - Pdf \n " +
                        "3 - Excel \n " +
                        "4 - Txt \n " +
                        "5 - Html \n" +
                        " f - *ВЫХОД ИЗ ПРОГРАММЫ* \n " + 
                        "Ввод: ");
                    choice = Console.ReadLine();
                    Console.Clear();

                    // Проверка на выход
                    if (choice == "f")
                    {
                        Console.WriteLine("\n\n\n\nВЫХОД\n\n\n\n");
                        break;
                    }
                    switch (choice)//действия по нажатию
                    {
                        case "1":
                            Word One = new Word();
                            One.Path();
                            One.Exists();
                            One.Name();
                            One.Author();
                            One.Theme();
                            One.Keywords();
                            Singleton.Instance.Output(One);
                            break;
                        case "2":
                            PDF two = new PDF();
                            two.Path();
                            two.Exists();
                            two.Name();
                            two.Author();
                            two.Theme();
                            two.Keywords();
                            Singleton.Instance.Output(two);
                            break;
                        case "3":
                            Excel three = new Excel();
                            three.Path();
                            three.Exists();
                            three.Name();
                            three.Author();
                            three.Theme();
                            three.Keywords();
                            Singleton.Instance.Output(three);
                            break;
                        case "4":
                            Txt four = new Txt();
                            four.Path();
                            four.Exists();
                            four.Name();
                            four.Author();
                            four.Theme();
                            four.Keywords();
                            Singleton.Instance.Output(four);
                            break;
                        case "5":
                            Html five = new Html();
                            five.Path();
                            five.Exists();
                            five.Name();
                            five.Author();
                            five.Theme();
                            five.Keywords();
                            Singleton.Instance.Output(five);
                            break;
                        default:
                            Console.WriteLine("Введён некорректный номер документа!");
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
                    if (instance == null) instance = new Singleton();
                    return instance;
                }
            }
            public void Output(Inform doc)
            {
                doc.Display();
            }
            private Singleton() { }
            private static Singleton instance;

        }
}
  

