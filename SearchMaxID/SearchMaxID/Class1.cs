using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SearchMaxID
{
    static public class SearchMaxID
    {
        static public int FindMaxID(SQLiteConnection File, string flag)
        {
            int maxID = 0;
            SQLiteCommand findMaxIndex = new SQLiteCommand(File);
            switch (flag)
            {
                case "prod": findMaxIndex.CommandText = "select max(prodid) from Product";
                    break;
                case "cl": findMaxIndex.CommandText = "select max(clid) from Client";
                    break;
                case "prov": findMaxIndex.CommandText = "select max(provid) from Provider";
                    break;
                case "bh": findMaxIndex.CommandText = "select max(bhid) from ByingHistory";
                    break;
                default: break;
            }
            SQLiteDataReader selectMax = findMaxIndex.ExecuteReader();
            if (selectMax.Read())
            {
                var v = selectMax.GetValue(0);
                try { maxID = Convert.ToInt32(v); }
                catch (Exception)
                { maxID = 0; }
            }
            return maxID;
        }
    }
}
