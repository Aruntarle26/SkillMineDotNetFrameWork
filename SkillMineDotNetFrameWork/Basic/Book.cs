using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.Basic
{
    public class Book
    {
        private int bookid;
        private string bookname;
        private string bookauthor;
        private double bookprice;
        /* public void AcceptDetails(int bookId, string bookName, string bookAuthor, double bookPrice)
         {
             this.bookId = bookId;
             this.bookName = bookName;
             this.bookAuthor = bookAuthor;
             this.bookPrice = bookPrice;
         }
         public void DisplayDetails()
         {
             Console.WriteLine("book id is: " + bookId);
             Console.WriteLine("book name is: " + bookName);
             Console.WriteLine("book author name is: " + bookAuthor);
             Console.WriteLine("book Price is: " + bookPrice);
         }*/
        public int BookId
        {
            set
            {
                bookid = value;
            }
            get
            {
                return bookid;
            }
        }
        public string BookName
        {
            set
            {
                bookname = value;
            }
            get
            {
                return bookname;
            }
        }
        public string BookAuthor
        {
            set
            {
                bookauthor = value;
            }
            get
            {
                return bookauthor;
            }
        }
        public double BookPrice
        {
            set
            {
                bookprice = value;
            }
            get
            {
                return bookprice;
            }
        }
        /*public override string ToString()
        {
           // return ;
        }*/

    }
   
}
