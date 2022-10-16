using System;
using Outside;
namespace Inside
{
    public class First:Third
    {
        public int publicNumber=10;
        private int PrivateNumber=20;
        public int PrivateOutput{get {return PrivateNumber;}}
        internal int InternalNumber=30;

        protected int ProtectedOutput=40;


        public int ProtectedInternalNumbers{get{return ProtctedInternalNumber;}}

        
    }
}