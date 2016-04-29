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
        public string ClientFirstName;
        public string ClientLastName;

        public Client()
        { }

        public Client(int ClientID, string ClientFirstName, string ClientLastName)
        {
            this.ClientID = ClientID;
            this.ClientFirstName = ClientFirstName;
            this.ClientLastName = ClientLastName;
        }

        public override string ToString()
        {
            return ClientID.ToString() + " " + ClientFirstName + " " + ClientLastName;
        }
    }

    public class ClientList
    {
        private List<Client> Clients;

        public ClientList()
        {
            Clients = new List<Client>();
        }

        public int Add(Client NewClient)
        {
            if (NewClient.ClientFirstName.Length > 20 || NewClient.ClientLastName.Length > 20)
                return 1;
            Clients.Add(NewClient);
            return 0;
        }

        public int Add(int ClientID, string ClientFirstName, string ClientLastName)
        {
            if (ClientFirstName.Length > 20 || ClientLastName.Length > 20)
                return 1;
            Clients.Add(new Client(ClientID, ClientFirstName, ClientLastName));
            return 0;
        }

        public bool Remove(Client DelClient)
        {
            try
            { Clients.Remove(DelClient); }
            catch (Exception)
            { return false; }
            return true;
        }

        public bool RemoveAt(int ClientIndex)
        {
            try
            { Clients.RemoveAt(ClientIndex); }
            catch (Exception)
            { return false; }
            return true;
        }

        public Client this[int i]
        {
            get { return Clients[i]; }
            set { Clients[i] = value; }
        }

        public int Count
        {
            get { return Clients.Count; }
        }
    }
}
