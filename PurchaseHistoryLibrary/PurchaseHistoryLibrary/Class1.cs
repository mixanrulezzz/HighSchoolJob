﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseHistoryLibrary
{
    public class PurchaseHistory
    {
        public int PurchaseHistoryID;
        public int ShipmentID;
        public int ClientID;
        public int Count;
        public int Day;
        public int Month;
        public int Year;

        public PurchaseHistory()
        { }

        public PurchaseHistory(int PurchaseHistoryID, int ShipmentID, int ClientID, int Count, int Day, int Month, int Year)
        {
            this.PurchaseHistoryID = PurchaseHistoryID;
            this.ShipmentID = ShipmentID;
            this.ClientID = ClientID;
            this.Count = Count;
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }

        public override string ToString()
        {
            return PurchaseHistoryID.ToString() + " " + ShipmentID.ToString() + " " + ClientID.ToString() + " " + Count.ToString() + " " + Day + "." + Month + "." + Year;
        }
    }

    public class PurchaseHistoryList
    {
        public List<PurchaseHistory> ListOfHistory;

        public PurchaseHistoryList()
        {
            ListOfHistory = new List<PurchaseHistory>();
        }

        public int Add(PurchaseHistory NewElement)
        {
            ListOfHistory.Add(NewElement);
            return 0;
        }

        public int Add(int PurchaseHistoryID, int ShipmentID, int ClientID, int Count, int Day, int Month, int Year)
        {
            ListOfHistory.Add(new PurchaseHistory(PurchaseHistoryID, ShipmentID, ClientID, Count, Day, Month, Year));
            return 0;
        }

        public bool UpdateAt(PurchaseHistory UpdElement, int ElementIndex)
        {
            ListOfHistory[ElementIndex] = UpdElement;
            return true;
        }

        public bool Remove(PurchaseHistory DelElement)
        {
            try { ListOfHistory.Remove(DelElement); }
            catch (Exception) { return false; }
            return true;
        }

        public bool RemoveAt(int PurchaseHistoryIndex)
        {
            try { ListOfHistory.RemoveAt(PurchaseHistoryIndex); }
            catch (Exception) { return false; }
            return true;
        }

        public PurchaseHistory this[int i]
        {
            get { return ListOfHistory[i]; }
            set { ListOfHistory[i] = value; }
        }

        public int Count
        {
            get { return ListOfHistory.Count; }
        }
    }
}