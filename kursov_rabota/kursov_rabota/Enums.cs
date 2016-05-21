using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov_rabota
{
    public enum Tables
    {
        Shipment,
        Client,
        Provider,
        ProviderShipment,
        PurchaseHistory,
        None
    };

    public enum Regimes
    {
        Create,
        Update,
        Delete
    };
}
