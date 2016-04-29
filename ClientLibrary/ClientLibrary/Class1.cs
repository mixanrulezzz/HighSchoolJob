using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLibrary
{
    public class Client
    {
        public int ClientID;
        public string ClientName;

        public Client()
        { }

        public Client(int ClientID, string ClientName)
        {
            this.ClientID = ClientID;
            this.ClientName = ClientName;
        }

        public override string ToString()
        {
            return ClientID.ToString() + " " + ClientName;
        }
    }

    public class ClientList
    {
        public List<Client> Clients;

        public ClientList()
        {
            Clients = new List<Client>();
        }

        public int Add(Client NewClient)
        {
            Clients.Add(NewClient);
            return 0;
        }

        public int Add(int ClientID, string ClientName)
        {
            Clients.Add(new Client(ClientID, ClientName));
            return 0;
        }

        public bool Remove(Client DelClient)
        {
            return true;
        }
    }
}
