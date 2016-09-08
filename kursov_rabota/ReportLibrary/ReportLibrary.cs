using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientLibrary;
using ShipmentLibrary;
using PurchaseHistoryLibrary;
using PDFWork;

namespace ReportLibrary
{
    public static class Report
    {
        public static bool ClientReport(string file, ClientList Clients, ShipmentList Shipments, PurchaseHistoryList PurHisList)
        {
            List<string> Names = new List<string>();
            List<int> Counts = new List<int>();
            List<int> Costs = new List<int>();

            for (int i = 0; i < Clients.Count; i++)
            {
                Names.Add(Clients[i].ClientLastName + " " + Clients[i].ClientFirstName);
                Counts.Add(0);
                Costs.Add(0);
                foreach (PurchaseHistory PH in PurHisList.ListOfHistory)
                {
                    if (PH.ClientID == Clients[i].ClientID)
                    {
                        Counts[i] += PH.Count;
                        foreach (Shipment SH in Shipments.Shipments)
                        {
                            if (SH.ShipmentID == PH.ShipmentID)
                            {
                                Costs[i] += SH.Price * PH.Count;
                                break;
                            }
                        }
                    }
                }
            }

            PDF.CreateClientReport(file, Names, Counts, Costs);
            return true;
        }
    }
}
