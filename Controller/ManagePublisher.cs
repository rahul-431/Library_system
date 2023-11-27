using System;
namespace Library_system{
    public class ManagePublisher{

        Publisher publish=new Publisher();
         public void addNewPublisher(string pubId, string name, string address)
        {
            publish.PubId=pubId;
            publish.Name=name;
            publish.Address=address;
        }
        public void removePublisher(string pubId)
        {

        }
        public string getAllPublisher()
        {
            return "Publisher Id: "+publish.PubId+" name: "+publish.Name+" address: "+publish.Address;
        }
    }
}