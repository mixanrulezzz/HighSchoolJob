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
        static int Product(SQLiteConnection File)
        {
            int maxID = 0;
            SQLiteCommand findMaxIndex = new SQLiteCommand(File);
            findMaxIndex.CommandText = "select max(prodid) from Product";
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
