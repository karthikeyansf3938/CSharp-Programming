namespace Question4
{
    public class BookInfo : DepartmentDetails
    {
        private static int s_bookId=100;
        public string BookId{get;}
        public string BookName{get; set;}
        public string AuthorName{get; set;}
        public double Price{get; set;}
        public BookInfo(string departmentId,string departmentName,string degree,string bookName,string authorName,double price):base(departmentId,departmentName,degree)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void ShowInfo()
        {
            Info();
            Console.WriteLine($"{BookId}\n{BookName}\n{AuthorName}\n{Price}");  
        }
    }
}