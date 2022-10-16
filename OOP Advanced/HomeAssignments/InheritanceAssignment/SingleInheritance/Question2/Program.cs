using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male);
        person.ShowInfo();
        AccountInfo accountInfo=new AccountInfo("AID1001","karthi","Thangaraj",70109328,"karthi@gmail.com",Gender.Male,"Nandambakkam","IOBA0003430",30000);
        accountInfo.UpdateInfo();
    }
}