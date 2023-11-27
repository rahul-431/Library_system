using System;
namespace Library_system{
    public class Publisher{
        private string pubId;
        private string address;
        private string name;
        public string PubId{
            get{return pubId;}
            set{pubId=value;}
        }
        public string Address{
            get{return address;}
            set{address=value;}
        }
        public string Name{
            get{return name;}
            set{name=value;}
        }
    }
}