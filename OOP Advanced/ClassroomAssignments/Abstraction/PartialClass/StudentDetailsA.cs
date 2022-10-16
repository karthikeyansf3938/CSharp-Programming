namespace PartialClass
{
    public partial class StudentDetails
    {
        public StudentDetails(string aadharId,string name,string fatherName,Gender gender,long phone,Department department, string year):base(aadharId,name,fatherName,gender,phone)
        {
            s_id++;
            StudentId="SID"+s_id;
            Department=department;
            Year=year;
        }
       
        
    }
}