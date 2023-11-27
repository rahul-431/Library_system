using System;
namespace Library_system{
    public class ManageMember{
        
        Member member=new Member();
        public void addNewMember(string memId, string name, string address)
        {
            member.MemId=memId;
            member.Name=name;
            member.Address=address;
        }
        public void removeMember(string memId)
        {

        }
        public string getALlMember()
        {
            return "Member Id: "+member.MemId+" name: "+member.Name+" address: "+member.Address;
        }
    }
}