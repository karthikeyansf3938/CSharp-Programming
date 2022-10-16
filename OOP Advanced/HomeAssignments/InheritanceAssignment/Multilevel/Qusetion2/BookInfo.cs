namespace Qusetion2
{
    public class BookInfo:IRackInfo,DepartmentDteails
    {
        private static int s_bookId=1000;
        public string BoookId{get;}
        public string BookName{get; set;}
        public string AuthorName{get; set;}
        public double Price{get; set;}
        public int Racknumber{get; set;}
        public int ColumnNumber{get; set;}
        public BookInfo(string bookName,string authorName,double price)
        {
            s_bookId++;
            BoookId="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public RackInfo(int racknumber,int columnnumber)
        {
            Racknumber=racknumber;
            ColumnNumber=columnnumber;
        }
    }
}