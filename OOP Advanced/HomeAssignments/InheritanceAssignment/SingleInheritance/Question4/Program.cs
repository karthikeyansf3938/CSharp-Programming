using System;
using System.Collections.Generic;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        List<DepartmentDetails> DepartmentList=new List<DepartmentDetails>();
        List<BookInfo> BookList=new List<BookInfo>();

        DepartmentDetails department=new DepartmentDetails("CSE","BE");
        DepartmentList.Add(department);

        BookInfo book=new BookInfo("DID1001","CSE","BE","LifeStyle","Kevin",200);
        BookList.Add(book);
        foreach(BookInfo books in BookList)
        {
            book.ShowInfo();
        }
    }
}