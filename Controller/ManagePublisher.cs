using System;
namespace Library_system{
    public class ManagePublisher{

        Publisher publish=new Publisher();
         public void addNewPublisher(string pubId, string name, string address)
        {
            publish.pubId=pubId;
            publish.name=name;
            publish.address=address;
        }
        public void removePublisher(string pubId)
        {

        }
        public string getAllPublisher()
        {
            return "Publisher Id: "+publish.pubId+" name: "+publish.name+" address: "+publish.address;
        }
    }
}