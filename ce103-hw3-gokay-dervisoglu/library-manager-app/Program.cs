using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement;
using FileOperation;
using Main;
using Bookfeatures;
using System.Threading;
using System.Security.Policy;

namespace library_manager_app
{

    public class Program1
    {
        public static int ID;
        public static string ID_Control;
        public static string Title;
        public static string Describe;
        public static string Author;
        public static string Category;
        public static int Year;
        public static string Year_Control;
        public static int Page;
        public static string Page_Control;
        public static string City;
        public static int Edition;
        public static string Edition_Control;
        public static string Editor;
        public static string Publisher;
        public static string Url;
        public static int DOI;
        public static int ISBN;
        public static int Price;
        public static string Rack;
        public static string Row;
        public static int SearchID;
        private static int c;


        public static void Main()
        {



            Console.SetCursorPosition(50, 12);
            string[] mains = { "L", "O", "A", "D", "I", "N", "G" };

            for (int i = 0; i < mains.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(mains[i]);
                System.Threading.Thread.Sleep(5);
            }

            Console.SetCursorPosition(50, 13);
            string[] aa = { "———————————————————————" };
            for (int i = 0; i < aa.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(aa[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.SetCursorPosition(50, 14);
            string[] ab = { "———————————————————————" };
            for (int i = 0; i < aa.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(aa[i]);
                System.Threading.Thread.Sleep(50);
            }

            System.Threading.Thread.Sleep(1000);



        logloop:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(22, 1);
            Console.WriteLine(" ----------------------- Library Management Application ----------------------- ");

            for (int i = 1; i <= 25; i++)
            {
                Console.SetCursorPosition(21, i);
                Console.Write("|\n");
            }
            for (int i = 1; i <= 25; i++)
            {
                Console.SetCursorPosition(101, i);
                Console.Write("|\n");
            }
            for (int i = 22; i <= 100; i++)
            {
                Console.SetCursorPosition(i, 25);
                Console.Write("=");
            }

            Console.SetCursorPosition(24, 8);
            Console.Write(" Please Enter Your Username : ");
            string username = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(24, 10);
            Console.Write(" Please Enter Your Password : ");
            string password = Console.ReadLine();
            ;
            Console.Clear();


            if (username == "gokay" && password == "6161")
            {
                bool close = true;
                while (close)
                {
                operationLoop:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(22, 1);
                    Console.Write(" ---------------------------------*- Menu -*---------------------------------\n");
                    for (int i = 1; i <= 25; i++)
                    {
                        Console.SetCursorPosition(21, i);
                        Console.Write("|\n");
                    }
                    for (int i = 1; i <= 25; i++)
                    {
                        Console.SetCursorPosition(101, i);
                        Console.Write("|\n");
                    }
                    for (int i = 22; i <= 100; i++)
                    {
                        Console.SetCursorPosition(i, 25);
                        Console.Write("=");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(26, 4);
                    Console.Write("1) Add Book\n");
                    Console.SetCursorPosition(26, 6);
                    Console.Write("2) Edit Book \n");
                    Console.SetCursorPosition(26, 8);
                    Console.Write("3) List Book\n");
                    Console.SetCursorPosition(26, 10);
                    Console.Write("4) Delete Book\n");
                    Console.SetCursorPosition(26, 12);
                    Console.Write("5) Borrow Book\n");
                    Console.SetCursorPosition(26, 14);
                    Console.Write("6) Search Book\n");
                    Console.SetCursorPosition(26, 16);
                    Console.Write("7) Close\n\n");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("Choose Your Option From Menu : ");

                    string option = Convert.ToString((Console.ReadLine()));

                    MainScreen s = new MainScreen();

                    if (option == "1")//Add book
                    {
                        Console.Clear();
                        Console.SetCursorPosition(44, 3);
                        Console.Write(" - Enter Book ID : ");

                        Console.SetCursorPosition(73, 3);
                        ID_Control = Console.ReadLine();
                        ID = Convert.ToInt32(ID_Control);


                        Console.SetCursorPosition(44, 4);
                        Console.Write(" - Enter Book Name : ");
                        Console.SetCursorPosition(73, 4);
                        Title = Console.ReadLine();


                        Console.SetCursorPosition(44, 5);
                        Console.Write(" - Enter Book Description : ");
                        Console.SetCursorPosition(73, 5);
                        Describe = Console.ReadLine();

                        Console.SetCursorPosition(44, 6);
                        Console.Write(" - Enter Book Author : ");
                        Console.SetCursorPosition(73, 6);
                        Author = Console.ReadLine();

                        Console.SetCursorPosition(44, 7);
                        Console.Write(" - Enter Book Category : ");
                        Console.SetCursorPosition(73, 7);
                        Category = Console.ReadLine();

                        Console.SetCursorPosition(44, 8);
                        Console.Write(" - Enter Book Year : ");
                        Console.SetCursorPosition(73, 8);
                        Year_Control = Console.ReadLine();
                        Year = Convert.ToInt32(Year_Control);

                        Console.SetCursorPosition(44, 9);
                        Console.Write(" - Enter Book Page : ");
                        Console.SetCursorPosition(73, 9);
                        Page_Control = Console.ReadLine();
                        Page = Convert.ToInt32(Page_Control);

                        Console.SetCursorPosition(44, 10);
                        Console.Write(" - Enter Book City : ");
                        Console.SetCursorPosition(73, 10);
                        City = Console.ReadLine();

                        Console.SetCursorPosition(44, 11);
                        Console.Write(" - Enter Book Edition : ");
                        Console.SetCursorPosition(73, 11);
                        Edition_Control = Console.ReadLine();
                        Edition = Convert.ToInt32(Edition_Control);

                        Console.SetCursorPosition(44, 12);
                        Console.Write(" - Enter Book Editors : ");
                        Console.SetCursorPosition(73, 12);
                        Editor = Console.ReadLine();

                        Console.SetCursorPosition(44, 13);
                        Console.Write(" - Enter Book Publisher : ");
                        Console.SetCursorPosition(73, 13);
                        Publisher = Console.ReadLine();

                        Console.SetCursorPosition(44, 14);
                        Console.Write(" - Enter Book URL : ");
                        Console.SetCursorPosition(73, 14);
                        Url = Console.ReadLine();

                        Console.SetCursorPosition(44, 15);
                        Console.Write(" - Enter Book DOI : ");
                        Console.SetCursorPosition(73, 15);
                        DOI = int.Parse(Console.ReadLine());

                        Console.SetCursorPosition(44, 16);
                        Console.Write(" - Enter Book ISBN : ");
                        Console.SetCursorPosition(73, 16);
                        ISBN = int.Parse(Console.ReadLine());

                        Console.SetCursorPosition(44, 17);
                        Console.Write(" - Enter Book Price : ");
                        Console.SetCursorPosition(73, 17);
                        Price = int.Parse(Console.ReadLine());

                        Console.SetCursorPosition(44, 18);
                        Console.Write(" - Enter Book Rack No via Words : ");
                        Console.SetCursorPosition(80, 18);
                        Rack = Console.ReadLine();

                        Console.SetCursorPosition(44, 19);
                        Console.Write(" - Enter Book Raw No via Words : ");
                        Console.SetCursorPosition(80, 19);
                        Row = Console.ReadLine();


                        s.AddBook(ID, Title, Describe, Author, Category, Year, Page, City, Edition, Editor, Publisher, Url, DOI, ISBN, Price, Rack, Row);
                    }
                    else if (option == "2") //Edit book
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.SetCursorPosition(38, 19);
                        Console.WriteLine(" -*- Enter the Book Information : ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.SetCursorPosition(28, 20);
                        Console.Write(" -*- Book ID : ");

                        Console.SetCursorPosition(28, 21);
                        Console.Write(" -*- Book Name : ");
                        Console.SetCursorPosition(39, 21);

                        Console.SetCursorPosition(28, 22);
                        Console.Write(" -*- Book Author : ");
                        Console.SetCursorPosition(41, 22);

                        Console.SetCursorPosition(28, 23);
                        Console.Write(" -*- Book Piece : ");
                        Console.SetCursorPosition(42, 23);



                        Console.WriteLine(" -*- Book Edited succesfully.");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        goto operationLoop;

                    }


                    else if (option == "3") //List book
                    {

                        Console.Clear();

                        for (c = 1; c < 5; c++)
                        {
                            byte[] bookWrittenBytes = FileUtility.ReadBlock(c, BookFeature.BOOK_DATA_BLOCK_SIZE, "C:\\Users\\gokay\\ce103-hw3-gokay-dervisoglu\\Library.dat");


                            BookFeature bookWrittenObject = BookFeature.ByteArrayBlockToBook(bookWrittenBytes);

                            int counter = 0;
                            int BOOKID;




                            try
                            {

                                BOOKID = Convert.ToInt32(bookWrittenObject.Id);

                                while (BOOKID > 0)
                                {
                                    BOOKID /= 10;
                                    counter++;
                                }

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write(" -*- Listelemek İçin 3'e Basınız");
                                Console.SetCursorPosition(35, 0);
                                option = Console.ReadLine();

                                int x = 25;
                                if (counter == 4 || option == "3")
                                {




                                    Console.SetCursorPosition(x, 5);
                                    Console.Write(" -*- Book ID : " + bookWrittenObject.Id);
                                    Console.SetCursorPosition(x, 6);
                                    Console.Write(" -*- Book Name : " + bookWrittenObject.Title);
                                    Console.SetCursorPosition(x, 7);
                                    Console.Write(" -*- Book Description : " + bookWrittenObject.Description);
                                    Console.SetCursorPosition(x, 8);
                                    Console.Write(" -*- Book Author : " + bookWrittenObject.Authors);
                                    Console.SetCursorPosition(x, 9);
                                    Console.Write(" -*- Book Categories : " + bookWrittenObject.Categories);
                                    Console.SetCursorPosition(x, 10);
                                    Console.Write(" -*- Book Year : " + bookWrittenObject.Years);
                                    Console.SetCursorPosition(x, 11);
                                    Console.Write(" -*- Book Page : " + bookWrittenObject.Pages);
                                    Console.SetCursorPosition(x, 12);
                                    Console.Write(" -*- Book City : " + bookWrittenObject.City);
                                    Console.SetCursorPosition(x, 13);
                                    Console.Write(" -*- Book Edition : " + bookWrittenObject.Edition);
                                    Console.SetCursorPosition(x, 14);
                                    Console.Write(" -*- Book Editor : " + bookWrittenObject.Editors);
                                    Console.SetCursorPosition(x, 15);
                                    Console.Write(" -*- Book Publisher : " + bookWrittenObject.Publishers);
                                    Console.SetCursorPosition(x, 16);
                                    Console.Write(" -*- Book URL : " + bookWrittenObject.URL);
                                    Console.SetCursorPosition(x, 17);
                                    Console.Write(" -*- Book DOI : " + bookWrittenObject.DOI);
                                    Console.SetCursorPosition(x, 18);
                                    Console.Write(" -*- Book ISBN : " + bookWrittenObject.ISBN);
                                    Console.SetCursorPosition(x, 19);
                                    Console.Write(" -*- Book Price : " + bookWrittenObject.Price);
                                    Console.SetCursorPosition(x, 20);
                                    Console.Write(" -*- Book Rack No : " + bookWrittenObject.Rack);
                                    Console.SetCursorPosition(x, 21);
                                    Console.Write(" -*- Book  Row No : " + bookWrittenObject.Row);
                                    Console.ReadKey();
                                    Console.SetCursorPosition(30, 25);
                                    Console.Write(" -*- For Exit Press Enter -*- ");
                                    Console.ReadKey();
                                    x = x + 25;
                                    Console.Clear();
                                }
                            }

                            catch (NullReferenceException)
                            {
                                Console.ReadKey();
                                goto operationLoop;
                            }


                        }



                    }
                    else if (option == "4")//Delete book
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.SetCursorPosition(38, 19);
                        Console.WriteLine(" - Enter the Book Information :  ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(28, 20);
                        Console.WriteLine(" - Book ID : ");
                        BookFeature a = new BookFeature();

                        int bookid;
                        Console.SetCursorPosition(38, 19);
                        bookid = int.Parse(Console.ReadLine());
                        FileUtility.DeleteBlock(bookid, BookFeature.BOOK_DATA_BLOCK_SIZE, "C:\\Users\\gokay\\ce103-hw3-gokay-dervisoglu\\Library.dat");
                    }
                    else if (option == "5") //Borrow book
                    {

                        Console.WriteLine("Book Succesfully Given");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        goto operationLoop;
                    }
                    else if (option == "6")//Seearch book
                    {
                        Console.Clear();

                        Console.SetCursorPosition(50, 7);
                        Console.Write("*Search By ID ");
                        Console.ReadKey();

                        Console.SetCursorPosition(65, 7);
                        //Console.ReadKey();

                        Console.SetCursorPosition(57, 7);
                        Console.Write("Please Enter ID: ");
                        SearchID = Convert.ToInt32(Console.ReadLine());

                        for (c = 1; c < 4; c++)
                        {



                            byte[] bookWrittenBytes = FileUtility.ReadBlock(c, BookFeature.BOOK_DATA_BLOCK_SIZE, "C:\\Users\\gokay\\ce103-hw3-gokay-dervisoglu\\Library.dat");
                            BookFeature bookWrittenObject = BookFeature.ByteArrayBlockToBook(bookWrittenBytes);

                            if (bookWrittenObject.Id == SearchID)
                            {

                                Console.Clear();

                                Console.SetCursorPosition(52, 5);
                                Console.Write(" - Book ID : " + bookWrittenObject.Id);
                                Console.SetCursorPosition(52, 6);
                                Console.Write(" - Book Name : " + bookWrittenObject.Title);
                                Console.SetCursorPosition(52, 7);
                                Console.Write(" - Book Description : " + bookWrittenObject.Description);
                                Console.SetCursorPosition(52, 8);
                                Console.Write(" - Book Author : " + bookWrittenObject.Authors);
                                Console.SetCursorPosition(52, 9);
                                Console.Write(" - Book Categories : " + bookWrittenObject.Categories);
                                Console.SetCursorPosition(52, 10);
                                Console.Write(" - Book Year : " + bookWrittenObject.Years);
                                Console.SetCursorPosition(52, 11);
                                Console.Write(" - Book Page : " + bookWrittenObject.Pages);
                                Console.SetCursorPosition(52, 12);
                                Console.Write(" - Book City : " + bookWrittenObject.City);
                                Console.SetCursorPosition(52, 13);
                                Console.Write(" - Book Edition : " + bookWrittenObject.Edition);
                                Console.SetCursorPosition(52, 14);
                                Console.Write(" - Book Editor : " + bookWrittenObject.Editors);
                                Console.SetCursorPosition(52, 15);
                                Console.Write(" - Book Publisher : " + bookWrittenObject.Publishers);
                                Console.SetCursorPosition(52, 16);
                                Console.Write(" - Book URL : " + bookWrittenObject.URL);
                                Console.SetCursorPosition(52, 17);
                                Console.Write(" - Book DOI : " + bookWrittenObject.DOI);
                                Console.SetCursorPosition(52, 18);
                                Console.Write(" - Book ISBN : " + bookWrittenObject.ISBN);
                                Console.SetCursorPosition(52, 19);
                                Console.Write(" - Book Price : " + bookWrittenObject.Price);
                                Console.SetCursorPosition(52, 20);
                                Console.Write(" - Book Rack No : " + bookWrittenObject.Rack);
                                Console.SetCursorPosition(52, 21);
                                Console.Write(" - Book  Row No : " + bookWrittenObject.Row);
                                Console.ReadKey();
                                Console.SetCursorPosition(55, 25);
                                Console.Write(" - For Exit Press Enter - ");
                                Console.ReadKey();
                                Console.Clear();
                                goto operationLoop;
                            }

                        }
                    }
                    else if (option == "7")//Exit funciton
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        Console.SetCursorPosition(50, 12);
                        Console.Write(" -----------------------------\r\n");
                        Console.SetCursorPosition(50, 13);
                        Console.Write(" ---------- Exiting ----------\r\n");
                        Console.SetCursorPosition(50, 14);
                        Console.Write(" -----------------------------\r\n");

                        System.Threading.Thread.Sleep(2000);
                        close = true;

                        break;


                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.SetCursorPosition(50, 12);
                Console.Write(" -----------------------------\r\n");
                Console.SetCursorPosition(50, 13);
                Console.Write(" --------- Try Again ---------\r\n");
                Console.SetCursorPosition(50, 14);
                Console.Write(" -----------------------------\r\n");

                System.Threading.Thread.Sleep(5000);
                Console.Clear();

                goto logloop;
            }

                    Console.ReadLine();
                    return;
                }

            }
        }
    


