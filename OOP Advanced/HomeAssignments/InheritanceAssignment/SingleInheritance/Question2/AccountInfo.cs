namespace Question2
{
    public class AccountInfo : PersonalInfo
    {
        private static int s_accountnumber=1000;
        public string AccountNumber{get;}

        public string BranchName{get; set;}

        public String IfscCode{get; set;}
        public double Balance{get; set;}

        public AccountInfo(string personalId,string name,string fatherName,long phone,string mail,Gender gender,string branchName,string ifscCode,double balance):base(personalId,name,fatherName,phone,mail,gender)
        {
            s_accountnumber++;
            AccountNumber="AID"+s_accountnumber;
            BranchName=branchName;
            IfscCode=ifscCode;
            Balance=balance;
        }
        public void UpdateInfo()
        {
            System.Console.WriteLine("\n------Update Info------");
            System.Console.WriteLine("\nAccount Number Id : "+AccountNumber);
            ShowInfo();
            Console.WriteLine($"\nBranchName : {BranchName} \nIFSC Code : {IfscCode} \nBalance : {Balance}");  
        }

    }
}