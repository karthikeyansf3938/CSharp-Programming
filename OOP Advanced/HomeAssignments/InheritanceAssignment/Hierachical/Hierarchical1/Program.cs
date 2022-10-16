using System;
namespace Hierarchical1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("--------Personal Details------------\n");
        PersonalDetails person=new PersonalDetails("Jose","Antony",new DateTime(2012,11,11),Gender.Male,"jj.com");
        person.ShowDetails();
        System.Console.WriteLine("\n--------Teacher Details-------------\n");
        TeacherDetails teacher = new TeacherDetails("Jose","Antony",new DateTime(2018,12,22),Gender.Male,"mm.com","ECE","Maths","Msc",2,DateTime.Now);
        teacher.ShowTeacher();
        System.Console.WriteLine("\n--------Principal Deatils-----------");
        PrincipalDetails principal=new PrincipalDetails("Jose","Antony",new DateTime(2019,03,04),Gender.Male,"kk.com","EEE",3,new DateTime(2021,03,03));
        principal.ShowPrincipal();

    }
}