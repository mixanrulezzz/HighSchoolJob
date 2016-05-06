using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderShipmentLibrary
{
    public class ProviderShipment
    {
        public int ProviderID;
        public int ShipmentID;

        public ProviderShipment()
        { }

        public ProviderShipment(int ShipmentID, int ProviderID)
        {
            this.ProviderID = ProviderID;
            this.ShipmentID = ShipmentID;
        }

        public override string ToString()
        {
            return ProviderID.ToString() + " " + ShipmentID.ToString();
        }
    }

    public class ProviderShipmentList
    {
        private List<ProviderShipment> LinkListProviderShipment;

        public ProviderShipmentList()
        {
            LinkListProviderShipment = new List<ProviderShipment>();
        }

        public int Add(ProviderShipment NewElement)
        {
            foreach (ProviderShipment ps in LinkListProviderShipment)
            {
                if (NewElement.ProviderID == ps.ProviderID && NewElement.ShipmentID == ps.ShipmentID)
                    return 2;
            }
            LinkListProviderShipment.Add(NewElement);
            return 0;
        }

        public int Add(int ShipmentID, int ProviderID)
        {
            foreach (ProviderShipment ps in LinkListProviderShipment)
            {
                if (ProviderID == ps.ProviderID && ShipmentID == ps.ShipmentID)
                    return 2;
            }
            LinkListProviderShipment.Add(new ProviderShipment(ShipmentID, ProviderID));
            return 0;
        }

        public bool Remove(ProviderShipment DelElement)
        {
            try { LinkListProviderShipment.Remove(DelElement); }
            catch(Exception) { return false; }
            return true;
        }

        public bool RemoveAt(int ProviderShipmentIndex)
        {
            try { LinkListProviderShipment.RemoveAt(ProviderShipmentIndex); }
            catch (Exception) { return false; }
            return true;
        }

        public ProviderShipment this[int i]
        {
            get { return LinkListProviderShipment[i]; }
            set { LinkListProviderShipment[i] = value; }
        }

        public int Count
        {
            get { return LinkListProviderShipment.Count; }
        }
    }
}
