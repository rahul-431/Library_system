using System;
namespace Library_system{
    public class Member{
        private string memId;
        private string name;
        private string address;

        public string MemId{
            get{return memId;}
            set{memId=value;}
        }
        public string Name{
            get{return name;}
            set{name=value;}
        }
        public string Address{
            get{return address;}
            set{address=value;}
        }
    }
}