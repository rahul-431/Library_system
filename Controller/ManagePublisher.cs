using System;
namespace Library_system{
    public class ManagePublisher{

        List<Publisher> publishers=new List<Publisher>();
         public void addNewPublisher(string pubId, string name, string address)
        {
            Publisher publish=new Publisher();
            publish.PubId=pubId;
            publish.Name=name;
            publish.Address=address;
            publishers.Add(publish);
        }
        public void removePublisher(string pubId)
        {

        }
        public List<Publisher> getAllPublisher()
        {
            return publishers;
        }
    }
}