namespace Qusetion2
{
    public class DepartmentDteails
    {
        private static int s_departmentId=100;
        public string DepartmentId{get;}
        public string DepartmentName{get; set;}
        public string Degree{get; set;}
        public DepartmentDteails(string departmentName,string degree)
        {
            s_departmentId++;
            DepartmentId="DID"+s_departmentId;
            DepartmentName=departmentName;
            Degree=degree;
        }
        public DepartmentDteails(string departmentId,string departmentName,string degree)
        {
            DepartmentId=departmentId;
            DepartmentName=departmentName;
            Degree=degree;
        }
    }
}