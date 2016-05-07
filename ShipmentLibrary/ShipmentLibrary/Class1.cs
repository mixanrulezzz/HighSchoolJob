﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentLibrary
{
    public class Shipment
    {
        public int ShipmentID { get; private set; }
        public string ShipmentName { get; set; }
        public int Price { get; set; }
        public string PhotoLink { get; set; }

        public Shipment()
        { }

        public Shipment(int ShipmentID, string ShipmentName, int Price, string PhotoLink)
        {
            this.ShipmentID = ShipmentID;
            this.ShipmentName = ShipmentName;
            this.Price = Price;
            this.PhotoLink = PhotoLink;
        }

        public override string ToString()
        {
            return ShipmentID.ToString() + " " + ShipmentName + " " + Price.ToString();
        }
    }

    public class ShipmentList
    {
        private List<Shipment> Shipments;

        public ShipmentList()
        {
            Shipments = new List<Shipment>();
        }

        public int Add(Shipment newElement)
        {            
            if (newElement.Price < 0)
                return 3;
            if (newElement.ShipmentName.Length > 50)
                return 1;
            Shipments.Add(newElement);
            return 0;
        }

        public int Add(int ShipmentID, string ShipmentName, int Price, string PhotoLink)
        {
            if (Price < 0)
                return 3;
            if (ShipmentName.Length > 50)
                return 1;
            Shipments.Add(new Shipment(ShipmentID, ShipmentName, Price, PhotoLink));
            return 0;
        }

        public bool UpdateAt(Shipment UpdElement, int ElementIndex)
        {
            Shipments[ElementIndex] = UpdElement;
            return true;
        }

        public bool Remove(Shipment DelElement)
        {
            try { Shipments.Remove(DelElement); }
            catch (Exception) { return false; }
            return true;
        }

        public bool RemoveAt(int ShipmentIndex)
        {
            try { Shipments.RemoveAt(ShipmentIndex); }
            catch { return false; }
            return true;
        }

        public Shipment this[int i]
        {
            get { return Shipments[i]; }
            set { Shipments[i] = value; }
        }

        public int Count
        {
            get { return Shipments.Count; }
        }
    }
}
