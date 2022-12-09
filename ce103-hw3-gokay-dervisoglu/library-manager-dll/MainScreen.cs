using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices.ComTypes;
using LibraryManagement;
using FileOperation;
using Bookfeatures;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Diagnostics;

namespace Main
{
    public class MainScreen
    {

        public void ControlFile(string path, string filename)
        {

            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            if (fileStream != null)
            {
                Console.Write(" File Opened ");
            }

            fileStream.Close();

        }




        public void AddBook(int Id, string Title, string Description, string Authors, string Categories , int Years , int Pages , string City 
                            , int Edition , string Editors , string Publishers , string Url , int Doi , int Isbn , int Price , string Rack , string Row)
        {
            BookFeature book1 = new BookFeature();


            book1.Id =Id;
            book1.Title = Title;
            book1.Description = Description;
            book1.Authors = Authors;
            book1.Categories =Categories;
            book1.Years = Years;
            book1.Pages = Pages;
            book1.City= City;
            book1.Edition = Edition;
            book1.Editors = Editors;
            book1.Publishers = Publishers;
            book1.URL= Url;
            book1.DOI= Doi;
            book1.ISBN= Isbn;
            book1.Price = Price;
            book1.Rack= Rack;
            book1.Row= Row;


           byte[] bookBytes1 = BookFeature.BookToByteArrayBlock(book1);

           
            FileUtility.AppendBlock(bookBytes1, "C:\\Users\\gokay\\ce103-hw3-gokay-dervisoglu\\Library.dat");

            Console.Clear();

            Console.SetCursorPosition(50, 8);
            Console.Write(" - Data Writing Is Successful -");
            Console.SetCursorPosition(50, 10);
            Console.WriteLine(" - Book ID : "+ Id);
            Console.SetCursorPosition(50, 11);
            Console.WriteLine(" - Book Name : "+Title);
            Console.SetCursorPosition(50, 12);
            Console.WriteLine(" - Book Description : "+ Description);
            Console.SetCursorPosition(50, 13);
            Console.WriteLine(" - Book Author : "+ Authors);
            Console.SetCursorPosition(50, 14);
            Console.WriteLine(" - Book Category : "+ Categories);
            Console.SetCursorPosition(50, 15);
            Console.WriteLine(" - Book's Year : "+Years);
            Console.SetCursorPosition(50, 16);
            Console.WriteLine(" - Book Pages : "+Pages);
            Console.SetCursorPosition(50, 17);
            Console.WriteLine(" - Book City : "+City);
            Console.SetCursorPosition(50, 18);
            Console.WriteLine(" - Book Edition : "+Edition);
            Console.SetCursorPosition(50, 19);
            Console.WriteLine(" - Book Editors : "+Editors);
            Console.SetCursorPosition(50, 20);
            Console.WriteLine(" - Book Publishers : "+Publishers);
            Console.SetCursorPosition(50, 21);
            Console.WriteLine(" - Book URL : "+Url);
            Console.SetCursorPosition(50, 22);
            Console.WriteLine(" - Book DOI : "+Doi);
            Console.SetCursorPosition(50, 23);
            Console.WriteLine(" - Book ISBN : " +Isbn);
            Console.SetCursorPosition(50, 24);
            Console.WriteLine(" - Book Price : " +Price);
            Console.SetCursorPosition(50, 25);
            Console.WriteLine(" - Book Rack No : " +Rack);
            Console.SetCursorPosition(50, 26);
            Console.WriteLine(" - Book Row No : " +Row);
            
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public void AddBook2(int id, string title, string description, string authors, string categories , int years, int pages, string city
                            , int edition, string editors, string publishers , string url, int doi, int isbn, int price, string rack, string row)
        {
            BookFeature book2 = new BookFeature();


            book2.Id = id;
            book2.Title = title;
            book2.Description = description;
            book2.Authors = authors;
            book2.Categories = categories;
            book2.Years = years;
            book2.Pages = pages;
            book2.City= city;
            book2.Edition = edition;
            book2.Editors = editors;
            book2.Publishers = publishers;
            book2.URL= url;
            book2.DOI= doi;
            book2.ISBN= isbn;
            book2.Price = price;
            book2.Rack= rack;
            book2.Row= row;






            byte[] bookBytes2 = BookFeature.BookToByteArrayBlock(book2);

            
            FileUtility.AppendBlock2(bookBytes2, "C:\\Users\\gokay\\ce103-hw3-gokay-dervisoglu\\Library.dat");

            Console.Clear();

            Console.SetCursorPosition(50, 8);
            Console.Write(" - Data Writing Is Successful -");
            Console.SetCursorPosition(50, 10);
            Console.WriteLine(" - Book ID : "+ id);
            Console.SetCursorPosition(50, 11);
            Console.WriteLine(" - Book Name : "+title);
            Console.SetCursorPosition(50, 12);
            Console.WriteLine(" - Book Description : "+ description);
            Console.SetCursorPosition(50, 13);
            Console.WriteLine(" - Book Author : "+ authors);
            Console.SetCursorPosition(50, 14);
            Console.WriteLine(" - Book Category : "+ categories);
            Console.SetCursorPosition(50, 15);
            Console.WriteLine(" - Book's Year : "+years);
            Console.SetCursorPosition(50, 16);
            Console.WriteLine(" - Book Pages : "+pages);
            Console.SetCursorPosition(50, 17);
            Console.WriteLine(" - Book City : "+city);
            Console.SetCursorPosition(50, 18);
            Console.WriteLine(" - Book Edition : "+edition);
            Console.SetCursorPosition(50, 19);
            Console.WriteLine(" - Book Editors : "+editors);
            Console.SetCursorPosition(50, 20);
            Console.WriteLine(" - Book Publishers : "+publishers);
            Console.SetCursorPosition(50, 21);
            Console.WriteLine(" - Book URL : "+url);
            Console.SetCursorPosition(50, 22);
            Console.WriteLine(" - Book DOI : "+doi);
            Console.SetCursorPosition(50, 23);
            Console.WriteLine(" - Book ISBN : " +isbn);
            Console.SetCursorPosition(50, 24);
            Console.WriteLine(" - Book Price : " +price);
            Console.SetCursorPosition(50, 25);
            Console.WriteLine(" - Book Rack No : " +rack);
            Console.SetCursorPosition(50, 26);
            Console.WriteLine(" - Book Row No : " +row);

            System.Threading.Thread.Sleep(1000);

        }
       
        public void PullBook()
        {

           

            byte[] bookWrittenBytes = FileUtility.ReadBlock(1, BookFeature.BOOK_DATA_BLOCK_SIZE, "C:\\Users\\gokay\\ce103-hw3-gokay-dervisoglu\\Library.dat");
            BookFeature bookWrittenObject = BookFeature.ByteArrayBlockToBook(bookWrittenBytes);
            
        }


        

    }
}
