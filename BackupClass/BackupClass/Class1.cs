using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientLibrary;
using ShipmentLibrary;
using ProviderLibrary;
using ProviderShipmentLibrary;
using PurchaseHistoryLibrary;

namespace BackupClass
{
    public class BackupClass
    {
        public ClientList Clients;
        public ProviderList Providers;
        public ShipmentList Shipments;
        public ProviderShipmentList ProviderShipment;
        public PurchaseHistoryList PurchaseHistory;

        public BackupClass(ClientList Clients, ProviderList Providers, ShipmentList Shipments, ProviderShipmentList ProviderShipment, PurchaseHistoryList PurchaseHistory)
        {
            this.Clients = Clients;
            this.Providers = Providers;
            this.Shipments = Shipments;
            this.ProviderShipment = ProviderShipment;
            this.PurchaseHistory = PurchaseHistory;
        }
    }
}
