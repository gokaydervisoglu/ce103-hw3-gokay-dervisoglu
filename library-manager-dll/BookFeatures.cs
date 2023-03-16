using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement;

namespace Bookfeatures
{
    public class BookFeature
    {

        #region Public Constants
        public const int ID_LENGTH = 4;

        public const int TITLE_MAX_LENGTH = 100;

        public const int DESCRIPTION_MAX_LENGTH = 100;

        public const int AUTHORS_NAME_MAX_LENGTH = 100;

        public const int CATEGORY_NAME_MAX_LENGTH = 100;

        public const int YEAR_MAX_LENGTH = 100;

        public const int PAGES_MAX_LENGTH = 100;

        public const int CITY_MAX_LENGTH = 100;

        public const int EDITION_MAX_LENGTH = 100;

        public const int EDITORS_MAX_LENGTH = 100;

        public const int PUBLISHERS_MAX_LENGTH = 100;

        public const int URL_MAX_LENGTH = 100;

        public const int DOI_MAX_LENGTH= 100;

        public const int ISBN_MAX_LENGTH = 100;

        public const int PRICE_MAX_LENGTH = 100;

        public const int RACK_MAX_LENGTH = 100;

        public const int ROW_MAX_LENGTH = 100;

        public const int BOOK_DATA_BLOCK_SIZE = ID_LENGTH + DESCRIPTION_MAX_LENGTH + AUTHORS_NAME_MAX_LENGTH + TITLE_MAX_LENGTH + CATEGORY_NAME_MAX_LENGTH + YEAR_MAX_LENGTH + PAGES_MAX_LENGTH + CITY_MAX_LENGTH
                        + EDITION_MAX_LENGTH + EDITORS_MAX_LENGTH + PUBLISHERS_MAX_LENGTH + URL_MAX_LENGTH + DOI_MAX_LENGTH + ISBN_MAX_LENGTH + PRICE_MAX_LENGTH + RACK_MAX_LENGTH + ROW_MAX_LENGTH;


        #endregion
        //TITLE_MAX_LENGTH +
        #region Private Fields
        private int _id;
        private string _title;
        private string _description;
        private string _authors;
        private string _categories;
        private int _year;
        private int _pages;
        private string _city;
        private int _edition;
        private string _editors;
        private string _publisher;
        private string _url;
        private int _doi;
        private int _isbn;
        private int _price;
        private string _rack;
        private string _row;
        #endregion

        #region Public Properties
        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Authors { get { return _authors; } set { _authors = value; } }
        public string Categories { get { return _categories; } set { _categories = value; } }
        public int Years { get { return _year; } set { _year = value; } }
        public int Pages { get { return _pages; } set { _pages = value; } }
        public string City { get { return _city;} set { _city = value; } }
        public int Edition { get { return _edition; } set { _edition = value;} }
        public string Editors { get { return _editors; } set { _editors = value; } }
        public string Publishers { get { return _publisher; } set { _publisher = value; } }
        public string URL { get { return _url; } set { _url = value; } }
        public int DOI { get { return _doi; } set { _doi = value; } }
        public int ISBN { get { return _isbn; } set { _isbn = value;} }
        public int Price { get { return _price; } set { _price = value; } }
        public string Rack { get { return _rack; } set { _rack = value; } }   
        public string Row { get { return _row; } set { _row = value; } }



        #endregion

       
        #region Utility Methods
        public static byte[] BookToByteArrayBlock(BookFeature book)
        {
            int index = 0;

            byte[] dataBuffer = new byte[BOOK_DATA_BLOCK_SIZE];

            #region copy book id
            byte[] idBytes = ConversionUtility.IntegerToByteArray(book.Id);
            Array.Copy(idBytes, 0, dataBuffer, index, idBytes.Length);
            index += BookFeature.ID_LENGTH;
            #endregion


            #region copy book title

            byte[] titleBytes = ConversionUtility.StringToByteArray(book.Title);
            Array.Copy(titleBytes, 0, dataBuffer, index, titleBytes.Length);
            index += BookFeature.TITLE_MAX_LENGTH;
            #endregion

            #region copy book description
            byte[] descBytes = ConversionUtility.StringToByteArray(book.Description);
            Array.Copy(descBytes, 0, dataBuffer, index, descBytes.Length);
            index += BookFeature.DESCRIPTION_MAX_LENGTH;
            #endregion

            #region copy book authors
            byte[] authorBytes = ConversionUtility.StringToByteArray(book.Authors);
            Array.Copy(authorBytes, 0, dataBuffer, index, authorBytes.Length);
            index += BookFeature.AUTHORS_NAME_MAX_LENGTH;
            #endregion


            #region copy book categories
            byte[] categoryBytes = ConversionUtility.StringToByteArray(book.Categories);
            Array.Copy(categoryBytes, 0, dataBuffer, index, categoryBytes.Length);
            index += BookFeature.CATEGORY_NAME_MAX_LENGTH;
            #endregion
            
            
            #region copy book year
            byte[] yearBytes = ConversionUtility.IntegerToByteArray(book.Years);
            Array.Copy(yearBytes, 0, dataBuffer, index, yearBytes.Length);
            index += BookFeature.YEAR_MAX_LENGTH;
            #endregion


            #region copy book pages
            byte[] pagesBytes = ConversionUtility.IntegerToByteArray(book.Pages);
            Array.Copy(pagesBytes,0,dataBuffer, index, pagesBytes.Length);
            index += BookFeature.PAGES_MAX_LENGTH;
            #endregion


            #region copy book cities
            byte[] citiesBytes = ConversionUtility.StringToByteArray(book.City);
            Array.Copy(citiesBytes,0,dataBuffer, index, citiesBytes.Length);
            index += BookFeature.CITY_MAX_LENGTH;
            #endregion


            #region copy book editions
            byte[] editionsBytes = ConversionUtility.IntegerToByteArray(book.Edition);
            Array.Copy(editionsBytes,0,dataBuffer, index, editionsBytes.Length);
            index += BookFeature.EDITION_MAX_LENGTH;
            #endregion


            #region copy book editors
            byte[] editorsBytes = ConversionUtility.StringToByteArray(book.Editors);
            Array.Copy(editorsBytes,0,dataBuffer, index, editorsBytes.Length);
            index += BookFeature.EDITORS_MAX_LENGTH;
            #endregion


            #region copy book publishers
            byte[] publishersBytes = ConversionUtility.StringToByteArray(book.Publishers);
            Array.Copy(publishersBytes,0,dataBuffer, index, publishersBytes.Length);
            index += BookFeature.PUBLISHERS_MAX_LENGTH;
            #endregion


            #region copy book url
            byte[] urlBytes = ConversionUtility.StringToByteArray(book.URL);
            Array.Copy(urlBytes , 0 , dataBuffer, index, urlBytes.Length);
            index += BookFeature.URL_MAX_LENGTH;
            #endregion


            #region copy book doi
            byte[] doiBytes = ConversionUtility.IntegerToByteArray(book._doi);
            Array.Copy(doiBytes ,0, dataBuffer, index, doiBytes.Length);
            index += BookFeature.DOI_MAX_LENGTH;
            #endregion


            #region copy book isbn
            byte[] isbnBytes = ConversionUtility.IntegerToByteArray(book._isbn);
            Array.Copy(isbnBytes ,0, dataBuffer, index, isbnBytes.Length);
            index += BookFeature.ISBN_MAX_LENGTH;
            #endregion


            #region copy book price
            byte[] priceBytes = ConversionUtility.IntegerToByteArray(book._price);
            Array.Copy(priceBytes , 0 , dataBuffer, index, priceBytes.Length);
            index += BookFeature.PRICE_MAX_LENGTH;
            #endregion


            #region copy book rack
            byte[] rackBytes = ConversionUtility.StringToByteArray(book._rack);
            Array.Copy(rackBytes,0,dataBuffer, index, rackBytes.Length);
            index += BookFeature.RACK_MAX_LENGTH;
            #endregion


            #region copy book row
            byte[] rowBytes = ConversionUtility.StringToByteArray(book._row);
            Array.Copy(rowBytes,0,dataBuffer, index, rowBytes.Length);
            index += BookFeature.ROW_MAX_LENGTH;
            #endregion

            if (index != dataBuffer.Length)
            {

                throw new ArgumentException("Index and DataBuffer Size Not Matched");
            }

            return dataBuffer;
        }

        public static BookFeature ByteArrayBlockToBook(byte[] byteArray)
        {

            BookFeature book = new BookFeature();

            if (byteArray.Length != BOOK_DATA_BLOCK_SIZE)
            {
                throw new ArgumentException("Byte Array Size Not Match with Constant Data Block Size");
            }
            else
            {



                int index = 0;


                #region copy book id
                byte[] idBytes = new byte[BookFeature.ID_LENGTH];
                Array.Copy(byteArray, index, idBytes, 0, idBytes.Length);
                book.Id = ConversionUtility.ByteArrayToInteger(idBytes);

                index += BookFeature.ID_LENGTH;
                #endregion

                #region copy book title
                byte[] titleBytes = new byte[BookFeature.TITLE_MAX_LENGTH];
                Array.Copy(byteArray, index, titleBytes, 0, titleBytes.Length);
                book.Title = ConversionUtility.ByteArrayToString(titleBytes);

                index += BookFeature.TITLE_MAX_LENGTH;
                #endregion

                #region copy book description
                byte[] descBytes = new byte[BookFeature.DESCRIPTION_MAX_LENGTH];
                Array.Copy(byteArray, index, descBytes, 0, descBytes.Length);
                book.Description = ConversionUtility.ByteArrayToString(descBytes);

                index += BookFeature.DESCRIPTION_MAX_LENGTH;
                #endregion

                #region copy book authors

                byte[] authorBytes = new byte[BookFeature.AUTHORS_NAME_MAX_LENGTH];
                Array.Copy(byteArray, index, authorBytes, 0, authorBytes.Length);
                book.Authors = ConversionUtility.ByteArrayToString(authorBytes);

                index += BookFeature.AUTHORS_NAME_MAX_LENGTH;
                #endregion


                #region copy book categories
                byte[] categoryBytes = new byte[BookFeature.CATEGORY_NAME_MAX_LENGTH];

                Array.Copy(byteArray, index, categoryBytes, 0, categoryBytes.Length);

                book.Categories = ConversionUtility.ByteArrayToString(categoryBytes);

                index += BookFeature.CATEGORY_NAME_MAX_LENGTH;


                #region copy book years 
                byte[] yearsBytes = new byte[BookFeature.YEAR_MAX_LENGTH];
                Array.Copy(byteArray, index, yearsBytes, 0, yearsBytes.Length);
                book.Years = ConversionUtility.ByteArrayToInteger(yearsBytes);
                index += BookFeature.YEAR_MAX_LENGTH;
                #endregion


                #region copy book pages 
                byte[] pagesBytes = new byte[BookFeature.PAGES_MAX_LENGTH];
                Array.Copy(byteArray , index ,yearsBytes, 0, pagesBytes.Length);
                book.Pages = ConversionUtility.ByteArrayToInteger(pagesBytes);
                index += BookFeature.PAGES_MAX_LENGTH;
                #endregion


                #region copy book cities
                byte[] citiesBytes = new byte[BookFeature.CITY_MAX_LENGTH];
                Array.Copy(byteArray , index ,citiesBytes, 0, citiesBytes.Length);
                book.City = ConversionUtility.ByteArrayToString(citiesBytes);
                index += BookFeature.CITY_MAX_LENGTH;
                #endregion


                #region copy book editions
                byte[] editionsBytes = new byte[BookFeature.EDITION_MAX_LENGTH];
                Array.Copy(byteArray , index , editionsBytes, 0, editionsBytes.Length);
                book.Edition = ConversionUtility.ByteArrayToInteger(editionsBytes);
                index += BookFeature.EDITION_MAX_LENGTH;
                #endregion


                #region copy book editors
                byte[] editorsBytes = new byte[BookFeature.EDITORS_MAX_LENGTH];
                Array.Copy(byteArray , index , editorsBytes, 0, editorsBytes.Length);
                book.Editors= ConversionUtility.ByteArrayToString(editorsBytes);
                index += BookFeature.EDITION_MAX_LENGTH;
                #endregion


                #region copy book publishers
                byte[] publishersBytes = new byte[BookFeature.PUBLISHERS_MAX_LENGTH];
                Array.Copy(byteArray , index , publishersBytes, 0, publishersBytes.Length);
                book.Publishers = ConversionUtility.ByteArrayToString(publishersBytes);
                index += BookFeature.PUBLISHERS_MAX_LENGTH;
                #endregion


                #region copy book url
                byte[] urlBytes = new byte[BookFeature.URL_MAX_LENGTH];
                Array.Copy(byteArray , index ,urlBytes, 0, urlBytes.Length);
                book.URL= ConversionUtility.ByteArrayToString(urlBytes);
                index += BookFeature.URL_MAX_LENGTH;
                #endregion


                #region copy book doi
                byte[] doiBytes = new byte[BookFeature.DOI_MAX_LENGTH];
                Array.Copy(byteArray, index , doiBytes, 0, doiBytes.Length);
                book.DOI = ConversionUtility.ByteArrayToInteger(doiBytes);
                index += BookFeature.DOI_MAX_LENGTH;
                #endregion


                #region copy book isbn
                byte[] isbnBytes = new byte[BookFeature.ISBN_MAX_LENGTH];
                Array.Copy(byteArray,index,isbnBytes, 0, isbnBytes.Length);
                book.ISBN = ConversionUtility.ByteArrayToInteger(isbnBytes);
                index += BookFeature.ISBN_MAX_LENGTH;
                #endregion


                #region copy book price
                byte[] priceBytes = new byte[BookFeature.PRICE_MAX_LENGTH];
                Array.Copy(byteArray,index,priceBytes, 0, priceBytes.Length);
                book.Price = ConversionUtility.ByteArrayToInteger(priceBytes);
                index += BookFeature.PRICE_MAX_LENGTH;
                #endregion


                #region copy book rack
                byte[] rackBytes = new byte[BookFeature.RACK_MAX_LENGTH];
                Array.Copy(byteArray,index,rackBytes, 0, rackBytes.Length);
                book.Rack = ConversionUtility.ByteArrayToString(rackBytes);
                index += BookFeature.RACK_MAX_LENGTH;
                #endregion


                #region copy book row
                byte[] rowBytes = new byte[BookFeature.ROW_MAX_LENGTH];
                Array.Copy(byteArray,index,rowBytes, 0, rowBytes.Length);
                book.Row= ConversionUtility.ByteArrayToString(rowBytes);
                index += BookFeature.ROW_MAX_LENGTH;
                #endregion


                

                #endregion


                if (index != byteArray.Length)
                {

                    throw new ArgumentException("Index and DataBuffer Size Not Matched");
                }

                if (book.Id == 0)
                {
                    return null;
                }
                else
                {
                    return book;
                }


            }
            #endregion

        }


    }
}