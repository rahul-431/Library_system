using System;
namespace Library_system{
    public class ManageMember{
        
        Member member=new Member();
        public void addNewMember(string memId, string name, string address)
        {
            member.memId=memId;
            member.name=name;
            member.address=address;
        }
        public void removeMember(string memId)
        {

        }
        public string getALlMember()
        {
            return "Member Id: "+member.memId+" name: "+member.name+" address: "+member.address;
        }
    }
}