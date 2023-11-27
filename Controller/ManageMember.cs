using System;
namespace Library_system{
    public class ManageMember{
        
        
        private List<Member> members=new List<Member>();
        public void addNewMember(string memId, string name, string address)
        {
            Member member=new Member();
            member.MemId=memId;
            member.Name=name;
            member.Address=address;
            members.Add(member);
        }
        public void removeMember(string memId)
        {

        }
        public List<Member> getAllMember()
        {
            return members;
        }
    }
}