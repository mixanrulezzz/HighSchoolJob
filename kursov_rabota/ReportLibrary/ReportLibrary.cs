﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientLibrary;
using ShipmentLibrary;
using PurchaseHistoryLibrary;
using PDFWork;
using FormatDateLibrary;

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

        public static bool ShipmentReport(string file, ShipmentList Shipments, PurchaseHistoryList PurHisList)
        {
            List<string> Titles = new List<string>();
            List<int> Prices = new List<int>();
            List<int> Counts = new List<int>();
            List<int> Costs = new List<int>();

            for (int i = 0; i < Shipments.Count; i++)
            {
                Titles.Add(Shipments[i].ShipmentName);
                Prices.Add(Shipments[i].Price);
                Counts.Add(0);
                foreach (PurchaseHistory PH in PurHisList.ListOfHistory)
                {
                    if (Shipments[i].ShipmentID == PH.ShipmentID)
                    {
                        Counts[i] += PH.Count;
                    }
                }
                Costs.Add(Shipments[i].Price * Counts[i]);
            }

            PDF.CreateShipmentReport(file, Titles, Prices, Counts, Costs);
            return true;
        }

        public static bool PurchaseHistoryReport(string file, ShipmentList Shipments, PurchaseHistoryList PurHisList)
        {
            List<string> Dates = new List<string>();
            List<int> Counts = new List<int>();
            List<int> Costs = new List<int>();

            for (int i = 0; i < PurHisList.Count; i++)
            {
                if (Dates.Count == 0)
                {
                    Dates.Add(FormatDate.GetDate(PurHisList[i].Day, PurHisList[i].Month, PurHisList[i].Year));
                    Counts.Add(PurHisList[i].Count);
                    foreach (Shipment SH in Shipments.Shipments)
                    {
                        if (SH.ShipmentID == PurHisList[i].ShipmentID)
                        {
                            Costs.Add(PurHisList[i].Count * SH.Price);
                            break;
                        }
                    }                    
                }
                else
                {
                    int numberOfDate = -1;
                    for (int j = 0; j < Dates.Count; j++)
                    {
                        if (FormatDate.GetDate(PurHisList[i].Day, PurHisList[i].Month, PurHisList[i].Year) == Dates[j])
                        {
                            numberOfDate = j;
                            break;
                        }                        
                    }
                    if (numberOfDate != -1)
                    {
                        Counts[numberOfDate] += PurHisList[i].Count;
                        foreach (Shipment SH in Shipments.Shipments)
                        {
                            if (SH.ShipmentID == PurHisList[i].ShipmentID)
                            {
                                Costs[numberOfDate] += PurHisList[i].Count * SH.Price;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Dates.Add(FormatDate.GetDate(PurHisList[i].Day, PurHisList[i].Month, PurHisList[i].Year));
                        Counts.Add(PurHisList[i].Count);
                        foreach (Shipment SH in Shipments.Shipments)
                        {
                            if (SH.ShipmentID == PurHisList[i].ShipmentID)
                            {
                                Costs.Add(PurHisList[i].Count * SH.Price);
                                break;
                            }
                        }
                    }
                }
            }

            PDF.CreatePurchaseHistoryReport(file, Dates, Counts, Costs);
            return true;
        }
    }
}
