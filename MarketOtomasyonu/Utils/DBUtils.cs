using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Utils
{
    internal static class DBUtils
    {
        public static void BackUpDB()
        {
            string SQL = $"BACKUP DATABASE MarketDatabase\r\nTO DISK = '{Environment.CurrentDirectory}\\Data\\MarketBackup.bak'\r\n";
        }

        public static void RestoreDB()
        {
            string SQL = $"BACKUP DATABASE MarketDatabase\r\nTO DISK = '{Environment.CurrentDirectory}\\Data\\MarketBackup.bak'\r\n";
        }
    }
}
