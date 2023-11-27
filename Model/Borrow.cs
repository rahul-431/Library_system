using System;
namespace Library_system{
    public class Burrow{
        private string return_date;
        private string due_date;
        private string issue;

        public string Return_date{
            get{return return_date;}
            set{return_date=value;}
        }
        public string Due_date{
            get{return due_date;}
            set{due_date=value;}
        }
        public string Issue{
            get{return issue;}
            set{issue=value;}
        }
    }
}