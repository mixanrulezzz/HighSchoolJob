﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentLibrary
{
    public class Shipment
    {
        public int shID { get; private set; }
        public string shName { get; set; }
        public int Price { get; set; }
        public string PhotoLink { get; set; }

        public Shipment()
        { }

        public Shipment(int ShipmentID, string ShipmentName, int Price, string PhotoLink)
        {
            shID = ShipmentID;
            shName = ShipmentName;
            this.Price = Price;
            this.PhotoLink = PhotoLink;
        }

        public override string ToString()
        {
            return shID.ToString() + " " + shName + " " + Price.ToString();
        }
    }

    public class ShipmentList
    {
        List<Shipment> Shipments;

        public ShipmentList()
        {
            Shipments = new List<Shipment>();
        }

        public int Add(Shipment newElement)
        {            
            if (newElement.Price < 0)
                return 3;
            Shipments.Add(newElement);
            return 0;
        }

        public int Add(int ShipmentID, string ShipmentName, int Price, string PhotoLink)
        {
            if (Price < 0)
                return 3;
            Shipments.Add(new Shipment(ShipmentID, ShipmentName, Price, PhotoLink));
            return 0;
        }

        public void Remove()
        { }
    }
}
