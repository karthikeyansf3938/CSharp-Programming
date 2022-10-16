namespace Question4
{
    public class DepartmentDetails
    {
        private static int s_departmenId=1000;
        public string DepartmentId{get;}
        public string DepartmentName{get; set;}
        public string Degree{get; set;}
        public DepartmentDetails(string departmentName,string degree)
        {
            s_departmenId++;
            DepartmentId="DID"+s_departmenId;
            DepartmentName=departmentName;
            Degree=degree;
        }
        public DepartmentDetails(string departmentId,string departmentName,string degree)
        {
            DepartmentId=departmentId;
            DepartmentName=departmentName;
            Degree=degree;
        }
        public void Info()
        {
            Console.WriteLine($"{DepartmentName}\n{Degree}");
        }
    }
}