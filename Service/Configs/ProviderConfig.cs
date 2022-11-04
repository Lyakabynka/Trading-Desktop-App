using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Exam.Service.Configs
{
    public enum Provider
    {
        MSSQL,
        SQLite,
    }

    public static class ProviderConfig
    {
        public static readonly string MSSQL = @"Server=DESKTOP-K58LVPP;Database=GameDb;Trusted_Connection=True;";
        public static readonly string SQLite = @"Data source=" + Directory.GetCurrentDirectory() + @"\Game.db";
        public static Provider Provider = Provider.MSSQL;
    }
}
